using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licencia.ClassOfContacts
{
    class DataGridEdit
    {

        //Borrar la info del dataGrid
        public void DeleteDataGridInfo(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        //Actualiza la info del datagrid
        public void CargarDataGrid(List<InfoContactos> listaContactos, DataGridView dataGridView)
        {
            DeleteDataGridInfo(dataGridView);
            foreach (InfoContactos info in listaContactos)
            {
                dataGridView.Rows.Add(info.Name, info.Number, info.Correo, info.Address);
            }

        }

    }
}
