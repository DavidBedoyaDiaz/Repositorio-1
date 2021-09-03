using System;
using System.Security.Cryptography;
using System.Text;

namespace Demo_Formulario
{
    class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string Perfil { get; set; }

        public string GetSHA1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }

        public void GuardarUsuario()
        {
            //Guardar como archivo json
        }

        public void ConsultarUsuario()
        {
            //Recuperar del archivo json el usuario
        }

             
    }
}
