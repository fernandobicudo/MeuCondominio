using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Services.Ferramentas
{
    public class GeradorDeSenhaProvisoria
    {
        

        public string GerarSenhaProvisoria()
        {
            string senhaProvisoria = "";
            int numero;
            char letra;
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                numero = random.Next(0, 9);
                letra = (char)random.Next(97, 122);
                senhaProvisoria += numero.ToString() + letra.ToString(); 
            }
            return senhaProvisoria; 
        }
    }
}
