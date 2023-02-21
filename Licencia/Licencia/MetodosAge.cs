using System;
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
        
        public MetodosAge()
        {
          
        }

        
        void separarInfo(string linea,DataGridView main,TreeView tVSubOne)
        {
            if(linea == null)
            {
                return;
            }

            string[] words = linea.Split('/');


            var parentNode = tVSubOne.Nodes[0];
            parentNode.Nodes.Add(words[0]);
            parentNode.LastNode.Tag = i.ToString();

            ClassOfContacts.InfoContactos info = new ClassOfContacts.InfoContactos(i.ToString(),words[0],words[1],words[2],words[3]);

            dataContact.Add(info);
            i++;
            
        }

        public void CargarInfo(DataGridView m,TreeView n)
        {
            FileStream f = new FileStream("data.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);

            n.Nodes.Clear();
            n.Nodes.Add("Contactos");

            i = 0;

            while (line != null)
            { 
                line = sr.ReadLine();
                separarInfo(line,m,n);
            }

            

            f.Close();
            sr.Close();
        }
        public void GuardarDatos(string nombre, string numero, string correo, string domicilio)
        {
            string principal;
        }
    }
}
