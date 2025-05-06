using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace SafeDevelopmentSemesterProject
{
    internal class Encryption
    {
        
        private static string key = "WceoPYsxltcMpA000PXdUCoRfIZEsIvbflxIejdPVn4="; // 32 bytes key for AES-256
        private static string iv = "KUO1ioouqNTLibU3M9pDlw==";  // 16 bytes IV for AES


        
        public static string Encrypt(string plainText)
        {
            Aes aesAlg = Aes.Create();


            aesAlg.Key = Encoding.UTF8.GetBytes(key,0,32);
            aesAlg.IV = Encoding.UTF8.GetBytes(iv,0,16);
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            MemoryStream msEncrypt = new MemoryStream();

            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(plainText);
                }
            }
            string encrypted = Convert.ToBase64String(msEncrypt.ToArray());
                
            return encrypted;
        }

     
    }
}

