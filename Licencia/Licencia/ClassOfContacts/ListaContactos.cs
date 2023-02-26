using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licencia.ClassOfContacts
{
    class ListaContactos
    {

        private List<InfoContactos> listaInfoContactos = new List<InfoContactos>();

        public List<InfoContactos> GetListaContactos()
        {
            return listaInfoContactos;
        }
        //Actualiza la informacion de la lista del contacto selecionado
        public void ActualizarInformacionDelContacto(string name, string number, string email, string address, string id)
        {
            foreach (InfoContactos info in listaInfoContactos)
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

        //Carga la informacion del contacto seleccionado
        public void LlenarInfoTextbox(TextBox nombre, TextBox numero, TextBox correo, TextBox domicilio, string id)
        {
            foreach (InfoContactos info in listaInfoContactos)
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


        public void AgregarDatos(string nombre, string numero, string correo, string domicilio, string id)
        {
            InfoContactos info = new InfoContactos(id.ToString(), nombre, numero, correo, domicilio);
            listaInfoContactos.Add(info);
            
            //0GuardarDatos();
        }


        public void EliminarDatos(string id)
        {
            foreach (InfoContactos info in listaInfoContactos)
            {
                if (info.Id == id)
                {
                    listaInfoContactos.RemoveAt(int.Parse(id));
                    break;
                }
            }

            //GuardarDatos();
            //CargarArbol();
            //CargarDataGrid();
        }



    }
}
