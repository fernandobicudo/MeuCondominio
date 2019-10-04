using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Services.Ferramentas
{
    public class GeradorDeSenhaProvisoria
    {
        public static GeradorDeSenhaProvisoria gerador;

        string senhaProvisoria = "";
        int numero;
        char letra;

        public string GerarSenhaProvisoria()
        {
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                numero = random.Next(0, 9);
                letra = (char)random.Next(33, 58);
                senhaProvisoria += numero + letra;
            }
            return senhaProvisoria;
        }
    }
}
