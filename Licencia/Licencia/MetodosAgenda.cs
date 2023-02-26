using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Licencia.ClassOfContacts;


namespace Licencia
{
    public class MetodosAge
    {

        //Propiedades
        private List<InfoContactos> dataContact = new List<InfoContactos>();
        private TreeView treeView;
        private DataGridView dataGridView;
        private ArchiveEdit archiveEdit;
        private DataGridEdit dataGridEdit;
        private ListaContactos listaContactos;
        private TreeViewEdit treeViewEdit;


        //Constructor
        public MetodosAge(DataGridView _dataGridView, TreeView _treeView)
        {
            treeView = _treeView;
            dataGridView = _dataGridView;
        }





       
    }
}
