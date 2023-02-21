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
        public MetodosAge mAge = new MetodosAge();
        public DataGridView main;
        public TreeView tVOne;
        public AddTab(DataGridView _main, TreeView _tVOne)
        {
            InitializeComponent();
            main = _main;
            tVOne = _tVOne;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            mAge.CargarInfo(main,tVOne);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
