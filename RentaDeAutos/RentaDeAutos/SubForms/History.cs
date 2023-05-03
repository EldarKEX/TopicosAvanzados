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
        public History()
        {
            InitializeComponent();
            InitializeComboBox();
        }


        void InitializeComboBox()
        {
            DataTable data = new SqlConexionClass().FillTableCar();

            cbCar.Items.Add("Todos");

            foreach (DataRow row in data.Rows)
            {
                cbCar.Items.Add(row["Brand"].ToString() + " - " + row["Model"].ToString());
            }

            cbCar.SelectedIndex = 0;
            
        }

        void UpdateDataGrid()
        {
            dataGridView1.Rows.Clear();
            DataTable data = new SqlConexionClass().GetByFilter(cbCar.SelectedIndex, dtpStart.Value, dtpEnd.Value);
            foreach(DataRow row in data.Rows)
            {
                dataGridView1.Rows.Add(row["PurchaseID"],row["DateStart"],row["DateEnd"],row["Amount"],row["Name"],row["LastName"],row["Cel"],row["AddressP"],"");
            }
        }
        private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                UpdateDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
    }
}
