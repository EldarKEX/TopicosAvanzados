using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlLibrary;


namespace UserLogin
{
    public partial class LoginControl: UserControl
    {
        private bool isClosed;
        private SqlClass sqlClass;

        public SqlClass SqlClass { get => sqlClass; set => sqlClass = value; }
        public bool IsClosed { get => isClosed; set => isClosed = value; }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlClass = new SqlClass(tbServerName.Text, tbDataBase.Text, tbUser.Text, tbPassword.Text);
            bool isConnection = sqlClass.TryConnection();
            if (isConnection)
            {
                isClosed = true;
                this.FindForm().Close();
                MessageBox.Show("Coneccion exitosa");
                return;
            }

            isClosed = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isClosed = false;
            this.FindForm().Close();
        }
    }
}
