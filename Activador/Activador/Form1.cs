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

namespace Activador
{
    public partial class Form1 : Form
    {
        private Registro B = new Registro();
        public Form1()
        {
            InitializeComponent();
        }

        string key = "b14ca9888a5e4233aace2ea2615a1916";


        private void button1_Click(object sender, EventArgs e)
        {
            Encriptacion A = new Encriptacion();
            string s = A.EncryptString(key, textBox1.Text);
           
            B.ReadSubKey(s);
            textBox1.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            B.CreateRegister();
            B.DeleteSubKey("LicenciaActiva");
            textBox1.Text = "";
        }
    }
}
