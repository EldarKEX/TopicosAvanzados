﻿using System;
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
        private AddTab tab1;
        private Encriptacion idKey = new Encriptacion();
        private Registro register = new Registro();
        private bool load = false;
        private MetodosAge;
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
            tab1 = new AddTab(dGVcontactos, treeView);
            tab1.mAge.CargarInfo();
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
                tab1.mAge.EliminarDatos(treeView.SelectedNode.Tag.ToString());
           
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView.SelectedNode.Text == "Contactos")
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


            tab1.mAge.CargarInfo2(tName, tNumber, tEmail, tAddress, treeView.SelectedNode.Tag.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(treeView.SelectedNode == null || treeView.SelectedNode.Text == "Contactos")
            {
                MessageBox.Show("Debe seleccionar primero un nodo");
                return;
            }
            tab1.mAge.GuardarInfoClass(tName.Text, tNumber.Text, tEmail.Text, tAddress.Text, treeView.SelectedNode.Tag.ToString());
            MessageBox.Show("Datos guardados correctamente");
        }

        private void tLimpiar_Click(object sender, EventArgs e)
        {
            tab1.mAge.DeleteDataGridInfo();
            tab1.mAge.RestablecerArbol();
        }
    }
}
