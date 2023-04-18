using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaDeAutos.Class
{
    class MainClass
    {
        private string error = "";

        public string Error { get => error; set => error = value; }

        public bool ValidateCel(string Cel)
        {
            long n;
            if (long.TryParse(Cel,out n) && Cel.Length == 10)
            {               
                return true;
            }

            error += "El telefono debe ser valido \n";
            
            return false;
        }

        public bool ValidateTb(string name, string lastName, string amount, string address)
        {
            if(name != "" && lastName != "" && amount != "" && address != "")
            {
                return true;
            }

            error += "Todos los campos tienen que estar rellenados \n";
            return false;
        }
        public bool ValidateCar(string car)
        {
            if(car == "Elegir auto")
            {
                error += "Tienes que elegir un carro \n";
                return false;
            }
            return true;
        }
        public bool ValidateAll(string name, string lastName,string amount, string address, string car, string cel)
        {
            bool celb = ValidateCel(cel);
            bool carb = ValidateCar(car);
            bool tb =  ValidateTb(name, lastName, amount, address);
            if (celb && carb && tb)
            {
                return true;
            }


            MessageBox.Show(error);
            return false;
        }
    }
}
