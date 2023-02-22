﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Licencia
{
    public class MetodosAge
    {
        String line = "a";
        int i = 0;
        List<ClassOfContacts.InfoContactos> dataContact = new List<ClassOfContacts.InfoContactos>();
        public TreeView tVSubOne;
        public DataGridView main;
        public MetodosAge(DataGridView _main, TreeView _tVSubOne)
        {
            tVSubOne = _tVSubOne;
            main = _main;
        }


        public void DeleteDataGridInfo()
        {
            while (main.Rows.Count > 1)
            {
                main.Rows.Remove(main.Rows[0]);
            }
        }
        public void CargarDataGrid()
        {
            DeleteDataGridInfo();
            CargarInfo();
            foreach (ClassOfContacts.InfoContactos info in dataContact)
            {
                main.Rows.Add(info.Name, info.Number, info.Correo, info.Address);
            }
            
        }
        
        void separarInfo(string linea)
        {
            if(linea == null)
            {
                return;
            }

            string[] words = linea.Split('/');

            ClassOfContacts.InfoContactos info = new ClassOfContacts.InfoContactos(i.ToString(),words[0],words[1],words[2],words[3]);

            dataContact.Add(info);
            i++;
            
        }

        public void GuardarInfoClass(string name, string number, string email, string address, string id )
        {
            foreach (ClassOfContacts.InfoContactos info in dataContact)
            {
                if (info.Id == id)
                {
                    info.Name = name;
                    info.Number = number;
                    info.Correo = email;
                    info.Address = address;
                    return;
                }
            }

        }

        public void CargarInfo2(TextBox nombre, TextBox numero, TextBox correo, TextBox domicilio, string id)
        {
           foreach (ClassOfContacts.InfoContactos info in dataContact)
           {
                if (info.Id == id)
                {
                    nombre.Text = info.Name;
                    numero.Text = info.Number;
                    correo.Text = info.Correo;
                    domicilio.Text = info.Address;
                    return;
                }
           }
        }

        public void RestablecerArbol()
        {
            tVSubOne.Nodes.Clear();
            tVSubOne.Nodes.Add("Contactos");
        }
        public void CargarArbol()
        {
            RestablecerArbol();

            var parentNode = tVSubOne.Nodes[0];

            int g = 0;

            foreach (ClassOfContacts.InfoContactos node in dataContact)
            {
                parentNode.Nodes.Add(node.Name);
                parentNode.LastNode.Tag = g.ToString();
                g++;
            }
           
        }

        public void CargarInfo()
        {
            FileStream f = new FileStream("data.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);

            //CargarArbol(n);

            i = 0;

            while (line != null)
            { 
                line = sr.ReadLine();
                separarInfo(line);
            }


            sr.Close();
            f.Close();
            
        }

        public void AgregarDatos(string nombre, string numero, string correo, string domicilio)
        {
            ClassOfContacts.InfoContactos info = new ClassOfContacts.InfoContactos(i.ToString(), nombre, numero, correo, domicilio);
            dataContact.Add(info);
            i++;
            GuardarDatos();
        }

        public void GuardarDatos()
        {
            if (File.Exists("data.txt"))
            {
                File.Delete("data.txt");
            }
            FileStream f = new FileStream("data.txt", FileMode.OpenOrCreate);
            StreamWriter sr = new StreamWriter(f);

            foreach(ClassOfContacts.InfoContactos info in dataContact)
            {
                string line = info.Name + "/" + info.Number + "/" + info.Address + "/" + info.Correo;
                sr.WriteLine(line);
            }



            sr.Close();
            f.Close();

            CargarInfo();
        }

        public void EliminarDatos(string id)
        {
            foreach (ClassOfContacts.InfoContactos info in dataContact)
            {
                if(info.Id == id)
                {
                    dataContact.RemoveAt(int.Parse(id));
                    break;
                }
            }

            GuardarDatos();
            CargarArbol();
            CargarDataGrid();
        }
    }
}
