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
        private List<InfoContactos> listInfoContactos;
        private TreeView treeView;
        private DataGridView dataGridView;
        private ArchiveEdit archiveEdit;
        private DataGridEdit dataGridEdit;
        private ListaContactos listaContactos;
        private TreeViewEdit treeViewEdit;


        //Constructor
        public MetodosAge(DataGridView _dataGridView, TreeView _treeView)
        {
            listInfoContactos = new List<InfoContactos>();
            treeView = _treeView;
            dataGridView = _dataGridView;
            archiveEdit = new ArchiveEdit();
            dataGridEdit = new DataGridEdit();
            listaContactos = new ListaContactos(listInfoContactos);
            treeViewEdit = new TreeViewEdit();

            archiveEdit.CargarInformacionDelTxt(listInfoContactos);
        }

        //Agrega un fila de datos al final de la lista
        public void AgregarUnaFila(InfoContactos infoContactos)
        {
            int contadorID = archiveEdit.GetContadorId();

            archiveEdit.SetContadorId(contadorID+1);
            
            infoContactos.Id = contadorID.ToString();

            listaContactos.AgregarFilaEnLIsta(infoContactos);
            archiveEdit.GuardarInformacionAlTxt(listInfoContactos);
            archiveEdit.CargarInformacionDelTxt(listInfoContactos);
        }

        //Actualiza el datagrid y el treeView
        public void ActualizarDgTv()
        {
            dataGridEdit.CargarDataGrid(listInfoContactos, dataGridView);
            treeViewEdit.CargarArbol(listInfoContactos, treeView);
        }

        //Cargar la informacion del contacto selecionado en los id
        public void CargarFilaPorID(TextBox name, TextBox number, TextBox email, TextBox address, string id)
        {
            listaContactos.LlenarInfoTextbox(name, number, email, address, id);
        }

        //Eliminar la informacion del contactos seleccionado por id
        public void EliminarFilaPorID(string ID)
        {
            listaContactos.EliminarFilaEnLista(ID);

            archiveEdit.GuardarInformacionAlTxt(listInfoContactos);
            archiveEdit.CargarInformacionDelTxt(listInfoContactos);

            ActualizarDgTv();
        }

        //Actualiza los datos del contacto selecionado
        public void ActualizarDatosPorId(string name, string number, string email, string address, string id)
        {
            listaContactos.ActualizarInformacionDelContacto(name,number,email,address,id);

            archiveEdit.GuardarInformacionAlTxt(listInfoContactos);
            archiveEdit.CargarInformacionDelTxt(listInfoContactos);

            ActualizarDgTv();
        }


        //Limpia el dataGrid y el treeView
        public void LimpiarDgTv()
        {
            dataGridEdit.DeleteDataGridInfo(dataGridView);
            treeViewEdit.RestablecerArbol(treeView);
        }
    }
}
