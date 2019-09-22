using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Services.Ferramentas
{
    public class Formatadores
    {
        public static String ConversaoDeDataParaString(DateTime data)
        {
            string dataResultado = data.ToString();
            return dataResultado;
        }

        public static DateTime FormatarDataParaBancoDeDados(string data)
        {
            DateTime dataRetorno;

            dataRetorno = DateTime.ParseExact(data, "dd/MM/yyyy", null);

            return dataRetorno;
        }

        public static string FormatarDataParaExibicao(string data)
        {
            return data.Substring(0, 10);
        }
    }
}
