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


namespace RentaDeAutos
{     
    
    public partial class TestSql : Form
    {
        private SqlConexionClass SqlConexionClass;
        private DataTable DataPurchase;
        
        public TestSql()
        {
            InitializeComponent();
            SqlConexionClass = new SqlConexionClass();
            DataPurchase = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataPurchase = SqlConexionClass.TryConnection();

            foreach (DataRow row in DataPurchase.Rows )
            {
                dataGridView1.Rows.Add(row[0],row[1],row[2],row[3], row[4], row[5], row[6], row[7]);
            }
        }
    }
}
