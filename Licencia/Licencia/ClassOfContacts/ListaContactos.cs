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

        private List<InfoContactos> listaInfoContactos;

        public ListaContactos(List<InfoContactos> _listaInfoContactos)
        {
            listaInfoContactos = _listaInfoContactos;
        }
        public List<InfoContactos> GetListaContactos()
        {
            return listaInfoContactos;
        }

        public void SetListaContactos(List<InfoContactos> _listaInfoContactos)
        {
            listaInfoContactos = _listaInfoContactos;
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

        //Agrega una fila de datos al final de la lista
        public void AgregarFilaEnLIsta(InfoContactos infoContactos)
        {   
            listaInfoContactos.Add(infoContactos);
        }


        //Elimina una fila en el id del contacto seleccionado
        public void EliminarFilaEnLista(string id)
        {
            foreach (InfoContactos info in listaInfoContactos)
            {
                if (info.Id == id)
                {
                    listaInfoContactos.RemoveAt(int.Parse(id));
                    break;
                }
            } 
        }

       

    }
}
