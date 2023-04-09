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
{//fdgdfgdfg
    public partial class Form1 : Form
    {
        AddTab tab1;
        Encriptacion idKey = new Encriptacion();
        Registro register = new Registro();
        bool load = false;

        void inicio()
        {

            string key = idKey.EncryptString("b14ca9888a5e4233aace2ea2615a1916", "holamundo");
            if (!register.ReadPrincipal(key))
            {
                MessageBox.Show("Error en la activacion de la clave del producto");
                this.Close();
            }
        }

        public Form1()
        {
            inicio();
            InitializeComponent();
            tab1 = new AddTab(dGVcontactos, treeView1);
            tab1.mAge.CargarInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            
            tab1.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tab1.mAge.CargarArbol();
            
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tab1.mAge.EliminarDatos(treeView1.SelectedNode.Tag.ToString());
           
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Text == "Contactos")
            {
                if (!load)
                {
                    load = true;
                    return;
                }
                tab1.mAge.CargarDataGrid();
                tab1.mAge.CargarArbol();
                return;
            }


            tab1.mAge.CargarInfo2(tName, tNumber, tEmail, tAddress, treeView1.SelectedNode.Tag.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode == null || treeView1.SelectedNode.Text == "Contactos")
            {
                MessageBox.Show("Debe seleccionar primero un nodo");
                return;
            }
            tab1.mAge.GuardarInfoClass(tName.Text, tNumber.Text, tEmail.Text, tAddress.Text, treeView1.SelectedNode.Tag.ToString());
            MessageBox.Show("Datos guardados correctamente");
        }

        private void tLimpiar_Click(object sender, EventArgs e)
        {
            tab1.mAge.DeleteDataGridInfo();
            tab1.mAge.RestablecerArbol();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
