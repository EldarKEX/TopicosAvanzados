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

namespace Agenda
{
    public partial class AddTab : Form
    {

        private string idContactos;
        private MetodosAgenda 
        public AddTab(string _idContactos)
        {
            idContactos = _idContactos;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tName.Text == ""|| tNumber.Text == "" || tEmail.Text == ""|| tAddress.Text == "")
            {
                MessageBox.Show("Error: Todos los campos deben de ser llenados");
                return;
            }

            InfoContactos infoContactos = new InfoContactos(idContactos,tName.Text,tNumber.Text,tEmail.Text,tAddress.Text);

            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
