using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlLibrary;

namespace TablePicker
{
    public partial class Main : Form
    {
        private Login login;
        private SqlClass sql;
        public Main()
        {
            login = new Login();
            login.ShowDialog();

            if (login.GetControl.IsClosed)
            {
                InitializeComponent();                
                sql = login.GetControl.SqlClass;
                InitializeTree();
                return;
            }

            this.Close();               
        }

        void InitializeTree()
        {
            DataTable table = sql.GetAllTable();
            foreach(DataRow row in table.Rows)
            {
                string data = row["TABLE_NAME"].ToString();
                treeView1.Nodes.Add(data);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string table = treeView1.SelectedNode.Text;

            DataTable data = sql.GetSelectedTable(table);

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            foreach (DataColumn dataColumn in data.Columns)
            {
                dataGridView1.Columns.Add(dataColumn.ColumnName, dataColumn.Caption);
            }

            foreach (DataRow dataRow in data.Rows)
            {
                dataGridView1.Rows.Add(dataRow.ItemArray);
            }
        }
    }
}
