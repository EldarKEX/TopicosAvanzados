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
        private bool visiblePassword;
        public ucLogin()
        {
            InitializeComponent();
            validacion = true;
            visiblePassword = false;
        }

        public bool VisiblePassword
        {
            get
            {
                return visiblePassword;
            }
            set
            {
                visiblePassword = value;
                tbPassword.UseSystemPasswordChar = visiblePassword;

            }
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
            if (textValidation.ValidarUsuario(tbUser.Text)&&textValidation.ValidarEmail(tbEmail.Text)&&textValidation.ValidarPassword(tbPassword.Text))
            {
                MessageBox.Show("Datos agregados correctamente");
            }
        }


        private void tbUser_Enter(object sender, EventArgs e)
        {
            if(tbUser.Text == "Usuario" && tbUser.ForeColor == Color.DarkGray)
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.Black;
            }
           
            panelUser.Height = 33;   
            labelUser.Visible = true;
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if(tbUser.Text == "")
            {
                tbUser.Text = "Usuario";
                tbUser.ForeColor = Color.DarkGray;
            }
            

            panelUser.Height = 21;
            labelUser.Visible = false;
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email" && tbEmail.ForeColor == Color.DarkGray)
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }

            panelEmail.Height = 33;
            labelEmail.Visible = true;
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Email";
                tbEmail.ForeColor = Color.DarkGray;
            }

            panelEmail.Height = 21;
            labelEmail.Visible = false;
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Contraseña" && tbPassword.ForeColor == Color.DarkGray)
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }

            panelPassword.Height = 33;
            labelPassword.Visible = true;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Contraseña";
                tbPassword.ForeColor = Color.DarkGray;
            }

            panelPassword.Height = 21;
            labelPassword.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
