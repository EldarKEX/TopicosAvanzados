using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licencia.ClassOfContacts
{
    class InfoContactos
    {
        private string name;
        private string number;
        private string correo;
        private string address;
        private string id;
           
        public InfoContactos(string _id,string _name, string _number, string _correo,string _address)
        {
            id = _id;
            name = _name;
            number = _number;
            correo = _correo;
            address = _address;

        }
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
