using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licencia.ClassOfContacts
{
    class TreeViewEdit
    {

        //Limpia el arbol y agrega el primer nodo
        public void RestablecerArbol(TreeView treeView)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add("Contactos");
        }


        //Carga todos todos contactos
        public void CargarArbol( List<InfoContactos> infoContactos, TreeView treeView)
        {
            RestablecerArbol(treeView);

            var parentNode = treeView.Nodes[0];

            int nuevoID = 0;

            foreach (InfoContactos node in infoContactos)
            {
                parentNode.Nodes.Add(node.Name);
                parentNode.LastNode.Tag = nuevoID.ToString();
                nuevoID++;
            }

        }
    }
}
