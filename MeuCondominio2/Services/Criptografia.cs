using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace MeuCondominio2.Services
{
    public class Criptografia
    {
        public static string Encriptar(string texto)
        {
            SHA384 sha = new SHA384CryptoServiceProvider();

            //processa o hash a partir dos bytes do texto
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(texto));

            //armazena o hash após este ser computado
            byte[] resultado = sha.Hash;

            StringBuilder stringBuilder = new StringBuilder();


            //modifica o resultado em dois dígitos hexadecimais para cada byte
            for (int i = 0; i < resultado.Length; i++)
                stringBuilder.Append(resultado[i].ToString("x2"));
            //ToString("x2") formata cada byte transformando-o
            //em dois caracteres hexadecimais em uppercase

            return stringBuilder.ToString();
        }
    }
}
