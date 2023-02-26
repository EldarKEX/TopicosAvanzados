using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Licencia.ClassOfContacts;
using Licencia;

namespace Agenda
{
    public partial class AddTab : Form
    {

        private MetodosAge metodosAge;
        
        public AddTab(MetodosAge _metodosAge)
        {
            InitializeComponent();
            metodosAge = _metodosAge;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(tName.Text == ""|| tNumber.Text == "" || tEmail.Text == ""|| tAddress.Text == "")
            {
                MessageBox.Show("Error: Todos los campos deben de ser llenados");
                return;
            }

            InfoContactos infoContactos = new InfoContactos("0",tName.Text,tNumber.Text,tEmail.Text,tAddress.Text);

            metodosAge.AgregarUnaFila(infoContactos);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
