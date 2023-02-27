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
    public partial class Form1 : Form
    {

        //Propiedades
        private AddTab addTab;
        private Encriptacion idKey = new Encriptacion();
        private Registro register = new Registro();
        private MetodosAge metodosAge;
        private bool load = false;
       
        
        //Constructor
        public Form1()
        {
            Inicio();
            InitializeComponent();
            metodosAge = new MetodosAge(dataGridView, treeView);
            addTab = new AddTab(metodosAge);
            dataGridView.Rows.Clear();
        }

        //Revisa si hay licencia Activa
        void Inicio()
        {
            string key = idKey.EncryptString("b14ca9888a5e4233aace2ea2615a1916", "holamundo");
            if (!register.ReadPrincipal(key))
            {
                MessageBox.Show("Error en la activacion de la clave del producto");
                Close();
            }
        }



        //Abre un formulario para agregar un contacto a la lista
        private void bAgregar_Click(object sender, EventArgs e)
        {
            addTab.ShowDialog(); 
        }


        //Actualiza la info del dataGrid y del TreeView
        private void button1_Click_1(object sender, EventArgs e)
        {
            metodosAge.ActualizarDgTv();  
        }


        //Eliminar el contacto seleccionado
        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                metodosAge.EliminarFilaPorID(treeView.SelectedNode.Tag.ToString());
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        //Carga la info del nodo seleccionado
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView.SelectedNode.Text == "Contactos")
            {
                if (!load)
                {
                    load = true;
                    return;
                }

                metodosAge.ActualizarDgTv();

                return;
            }

            metodosAge.CargarFilaPorID(tName, tNumber, tEmail, tAddress, treeView.SelectedNode.Tag.ToString());
        }


        //Actualiza la info de los contactos
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if(treeView.SelectedNode == null || treeView.SelectedNode.Text == "Contactos")
            {
                MessageBox.Show("Debe seleccionar primero un nodo");
                return;
            }
            metodosAge.ActualizarDatosPorId(tName.Text,tNumber.Text,tEmail.Text,tAddress.Text,treeView.SelectedNode.Tag.ToString());
            MessageBox.Show("Datos guardados correctamente");
        }


        //Limpia los datos del treeView y del DataGrid
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            metodosAge.LimpiarDgTv();
        }
    }
}
