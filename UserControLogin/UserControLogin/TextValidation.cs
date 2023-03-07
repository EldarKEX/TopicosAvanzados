using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControLogin
{
    class TextValidation
    {
        bool ContainsTwoNumbers(string numbers)
        {
            int count = 0;
            foreach (char letter in numbers)
            {
                if (Char.IsDigit(letter))
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }

            return true;
        }
        public bool ValidarUsuario(string usuario)
        {
            if(usuario.Length < 2)
            {
                return false;
            }

            string usuarioLOWER = usuario.ToLower().Substring(1);
              

            //Validacion 1
            if (!Char.IsUpper(usuario[0]))
            {
                return false;
            }

            //Validacion 2
            if(usuario.Substring(1) != usuarioLOWER)
            {
                return false;
            }

            if (!ContainsTwoNumbers(usuario))
            {
                return false;
            }

            return true;
        }

        public bool ValidarPassword(string password)
        {
            bool upper = false;
            bool lower = false;
            bool twoNumbers = ContainsTwoNumbers(password);

            foreach (char letter in password)
            {    
                if (Char.IsLetter(letter))
                {
                     if (Char.IsUpper(letter))
                     {
                         upper = true;
                     }

                     if (Char.IsLower(letter))
                     { 
                         lower = true;
                     }
                }

            }
            if (lower && upper && twoNumbers)
            {
                return true;
            }

            return false;


        }

        public bool ValidarEmail(string email)
        {
            int indexSymbol = email.IndexOf("@");
            if (indexSymbol < 1)
            {
                return false;
            }
            int indexPunto = email.IndexOf(".");
            if (indexPunto <= indexSymbol + 2)
            {
                return false;
            }
            if (indexPunto == email.Length - 1)
            {
                return false;
            }


            return true;

        }
    }
}
