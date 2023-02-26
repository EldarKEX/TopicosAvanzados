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
        public void DeleteDataGridInfo(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 1)
            {
                dataGridView.Rows.Remove(dataGridView.Rows[0]);
            }
        }
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
