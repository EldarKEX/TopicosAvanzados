using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlRentCar;

namespace RentaDeAutos.SubForms
{
    public partial class History : Form
    {

        private bool thereIsFilterALL;
        public History()
        {
            InitializeComponent();
            InitializeComboBox();
            thereIsFilterALL = true;
        }


        void InitializeComboBox()
        {
            DataTable data = new SqlConexionClass().FillTableCar();

            cbCar.Items.Add("Todos");

            foreach (DataRow row in data.Rows)
            {
                cbCar.Items.Add(row["Brand"].ToString() + " - " + row["Model"].ToString());
            }

            
        }

        void CalculateTotalAmount(DataTable data)
        {
            double total = 0;

            foreach (DataRow row in data.Rows)
            {
                total += (double)row["Amount"];
            }

            tbTotal.Text = total.ToString();
        }




        void UpdateDataGrid()
        {
            dataGridView1.Rows.Clear();
            DataTable data = new SqlConexionClass().GetByFilter(cbCar.SelectedIndex, dtpStart.Value, dtpEnd.Value);
            foreach(DataRow row in data.Rows)
            {
                dataGridView1.Rows.Add(row["PurchaseID"],row["DateStart"],row["DateEnd"],row["Amount"],row["Name"],row["LastName"],row["Cel"],row["AddressP"],row["Brand"] + " - " + row["Model"]);
            }

            CalculateTotalAmount(data);
        }

        void UpdateDataGrid(DataTable data)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridView1.Rows.Add(row["PurchaseID"], row["DateStart"], row["DateEnd"], row["Amount"], row["Name"], row["LastName"], row["Cel"], row["AddressP"], row["Brand"] + " - " + row["Model"]);
            }

            CalculateTotalAmount(data);
        }



        private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                UpdateDataGrid();
                thereIsFilterALL = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            new SqlConexionClass().DeleteRecordId(selectedRow);

            if (thereIsFilterALL)
            {
                UpdateDataGrid(new SqlConexionClass().FillPurchase());
                return;
            }

            UpdateDataGrid();
            
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
            thereIsFilterALL = false;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
            thereIsFilterALL = false;
        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            UpdateDataGrid(new SqlConexionClass().FillPurchase());
            thereIsFilterALL = true;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void History_Shown(object sender, EventArgs e)
        {
            UpdateDataGrid(new SqlConexionClass().FillPurchase());
        }
    }
}
