using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Licencia
{
    public class Encriptacion
    {
        public static byte[] EncryptStringToBytes(string codigo, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

 
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            swEncrypt.Write(codigo);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }
        public string Encriptar(string codigo)
        {
            Rijndael myEncrypt  = Rijndael.Create();
            byte[] encrypted = EncryptStringToBytes(codigo, myEncrypt.Key, myEncrypt.IV);


            return encrypted.ToString();
        }


        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
  
            string plaintext = null;

            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
 
        public string Desencriptar(string codigo)
        {
            byte[] descrypt = Encoding.ASCII.GetBytes(codigo); 
            Rijndael myEncrypt = Rijndael.Create();
            string roundtrip = DecryptStringFromBytes(descrypt, myEncrypt.Key, myEncrypt.IV);
            return roundtrip;
        }
    }
}
