using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeUsuario
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private Color foreColor;
        private Color backColor;
        private string text;


        [Category ("User properties")]
        public Color ForeColor2
        {
            get{
                return foreColor;
            } 
            set{
                foreColor = value;
                btnGuardar.ForeColor = foreColor;
            }
        }


        [Category("User properties")]
        public Color BackColor2
        {
            get
            { 
                return backColor;
            }
            set
            {
                backColor = value;
                btnGuardar.BackColor = backColor;
            }
        }

        [Category("User properties")]
        public String Text2
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                btnGuardar.Text = text;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
