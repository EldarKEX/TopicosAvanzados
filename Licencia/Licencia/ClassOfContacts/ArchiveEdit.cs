using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Licencia.ClassOfContacts
{
    class ArchiveEdit
    {

        //Propiedad
        private int contadorId = 0;

        public ArchiveEdit()
        {
           
        }


        //Obtiene el contador de numero de id asignados
        public int GetContadorId()
        {
            return contadorId;
        }

        //Cambia el valor del contador de los id asignados
        public void SetContadorId(int value)
        {
            contadorId = value;
        }


        //Agrega las filas a la lista principal del archivo
        private void AgregarFilasALista(string fila, List<InfoContactos> listaContactos)
        {
            if (fila == null)
            {
                return;
            }

            string[] words = fila.Split('/');

            InfoContactos info = new InfoContactos(contadorId.ToString(), words[0], words[1], words[2], words[3]);

            listaContactos.Add(info);
            contadorId++;

        }

        //Carga la informacion del archivo por filas (o renglones)
        public void CargarInformacionDelTxt(List<InfoContactos> listaContactos)
        {
            FileStream fileStream = new FileStream("data.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            listaContactos.Clear();

            contadorId = 0;
            string fila = ".";

            while (fila != null)
            {
                fila = streamReader.ReadLine();
                AgregarFilasALista(fila, listaContactos);
            }


            streamReader.Close();
            fileStream.Close();
        }


        //Extrae la info de lista y la guiarda en un txt
        public void GuardarInformacionAlTxt(List<InfoContactos> listaContactos)
        {
            if (File.Exists("data.txt"))
            {
                File.Delete("data.txt");
            }
            FileStream fileStream = new FileStream("data.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream);


            foreach (InfoContactos info in listaContactos)
            {
                string fila = info.Name + "/" + info.Number + "/" + info.Address + "/" + info.Correo;
                streamWriter.WriteLine(fila);
            }

            streamWriter.Close();
            fileStream.Close();
        }


    }
}
