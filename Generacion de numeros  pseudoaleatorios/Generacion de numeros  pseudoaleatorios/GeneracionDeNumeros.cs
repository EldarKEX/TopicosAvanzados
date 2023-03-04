using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generacion_de_numeros__pseudoaleatorios
{
    class GeneracionDeNumeros
    {
       

        public bool ValidarSemilla(string semilla)
        {

            if(semilla.Length != 4)
            {
                return false;
            }

            return true;
        }

        public bool ValidarE(string e)
        {
            if(int.Parse(e) % 2 == 0 && int.Parse(e) >= 8)
            {
                return true;
            }

            return false;
        }
        public string CalcularCuadrado(string semilla,string e)
        {
            
            string numeroText = Math.Pow(double.Parse(semilla), 2).ToString();

            if (numeroText.Length < double.Parse(e))
            {
                while(numeroText.Length < double.Parse(e))
                {
                    numeroText = "0" + numeroText;
                }

                return numeroText;
            }
            return numeroText;
        }


        public string CalcularNuevaSemilla(string numero,string e)
        {
            int numeroLenght = numero.Length;

            int indiceInicial = (numeroLenght - 4) / 2;

            string solucion = numero.Substring(indiceInicial, 4);

            return solucion;
        }

        public string CalcularRi(string semilla)
        {
            float solucion = float.Parse(semilla) / 10000;

            return solucion.ToString();
        }

    }
}
