using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Licencia
{
    public class Registro
    {

        //Llave global que guarda la ruta de la licencia
        public RegistryKey key;


        //Creando el registro y su subllave
        public void CreateRegister()
        {
            key = Registry.CurrentUser.CreateSubKey("LicenciaWindows10");
            
            RegistryKey sk1 = key.CreateSubKey("LicenciaActiva");



            //Para que no de error
            if(sk1.ValueCount < 1)
            {
                sk1.SetValue("ID", "");
                sk1.SetValue("Software", "AgendaApp");
                sk1.SetValue("Version", "1.2.21");
            }   
        }


        //Compara la llave alamcenada en el registro con la proporciona
       public bool ReadPrincipal(string keyP)
       {
            CreateRegister();
            RegistryKey sk1 = key.OpenSubKey("LicenciaActiva", true);
            if (keyP == sk1.GetValue("ID").ToString())
            {
                return true;
            }
            return false;
        }

        //Lee la subllave y almacena el Id encriptado
        public void ReadSubKey(string idValue)
        {
            CreateRegister();
            RegistryKey sk1 = key.OpenSubKey("LicenciaActiva",true);
          

            sk1.SetValue("ID", idValue);
            sk1.SetValue("Software", "AgendaApp");
            sk1.SetValue("Version", "1.2.21");
        }


        //Borra la subllave junto con el id almacenado
        public void DeleteSubKey(string subkey)
        {
            key.DeleteSubKey(subkey);
        }
        
    }
}
