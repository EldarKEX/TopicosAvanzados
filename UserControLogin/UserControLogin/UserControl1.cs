using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControLogin
{
    public partial class ucLogin: UserControl
    {
        private bool validacion;
        public ucLogin()
        {
            InitializeComponent();
            validacion = true;
        }

        public bool Validacion
        {
            get
            {
                return validacion;
            }
            set
            {
                validacion = value;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validacion)
            {
                return;
            }

            TextValidation textValidation = new TextValidation();
            if (textValidation.ValidarEmail(tbEmail.Text))
            {
                MessageBox.Show("Datos agregados correctamente");
            }
        }


        private void tbUser_Enter(object sender, EventArgs e)
        {

        }
    }
}
