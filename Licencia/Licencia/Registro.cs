using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Licencia
{
    public class Registro
    {

        public RegistryKey key;
        public void CreateRegister()
        {
            key = Registry.CurrentUser.CreateSubKey("LicenciaWindows10");
            key.CreateSubKey("LicenciaActiva");
        }

        public void ReadSubKey(string idValue)
        {
            RegistryKey sk1 = key.OpenSubKey("LicenciaActiva",true);
            sk1.SetValue("ID", idValue);
            sk1.SetValue("Software", "AgendaApp");
            sk1.SetValue("Version", "1.2.21");
        }

        public void DeleteSubKey(string subkey)
        {
            key.DeleteSubKey(subkey);
        }
        
    }
}
