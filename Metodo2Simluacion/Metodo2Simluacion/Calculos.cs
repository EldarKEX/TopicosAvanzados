using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo2Simluacion
{
    class Calculos
    {
        private int semilla1;
        private int semilla2;

        public Calculos(string semilla1, string semilla2)
        {
            this.semilla1 = int.Parse(semilla1);
            this.semilla2 = int.Parse(semilla2);
        }

        public string CalcularNewRn()
        {
            string rn = "";

            return rn;
        }

        public string CalcularNewRnPlusOne()
        {
            string rnPlusOne = "";


            return rnPlusOne;
        }

        public string CalcularRnSquare()
        {
            string rnSquare = "";

            Double doubleRnSquar = semilla1 * semilla2;

            return doubleRnSquar.ToString();
        }

        public string CalcularMR(string rnSquare)
        {
            string mr = "";

            if (rnSquare.Length == 6) { }
            {
                mr = rnSquare.Substring(1, 4);
                return mr;
            }

            mr = rnSquare.Substring(1, 3);
            return mr;
        }


        public string CalcularVal1(string )
        {
            string val1 = "";


            return val1;
        }

        public string CalcularVal2()
        {
            string val2 = "";
            return val2;
        }

    
    }
}
