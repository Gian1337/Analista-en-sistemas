using System;
using System.Security.Cryptography;
using System.Text;

namespace Services
{
    public class Security
    {
        public static string EncriptarMD5(string texto)
        {
            string hash = "hash de encriptado";
            byte[] data = Encoding.UTF8.GetBytes(texto);

            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(resultado);
        }

        public static string DesencriptarMD5(string textoEnc)
        {
            string hash = "hash de encriptado";
            byte[] data = Convert.FromBase64String(textoEnc);

            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}
