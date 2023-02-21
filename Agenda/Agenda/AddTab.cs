using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Licencia;
namespace Agenda
{
    public partial class AddTab : Form
    {

        public DataGridView main;
        public TreeView tVOne;
        public MetodosAge mAge;
        
        public AddTab(DataGridView _main, TreeView _tVOne)
        {
            InitializeComponent();
            main = _main;
            tVOne = _tVOne;
            mAge = new MetodosAge(main,tVOne);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mAge.AgregarDatos(tName.Text, tNumber.Text, tEmail.Text, tAddress.Text);
            Close();
            //mAge.CargarInfo(main,tVOne);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
