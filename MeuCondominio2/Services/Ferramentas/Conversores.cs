using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Services.Ferramentas
{
    public class Conversores
    {
        public static String ConversaoDeDataParaString(DateTime data)
        {
            string dataResultado = data.ToString().Replace('/', '-');
            return dataResultado;
        }

        public static DateTime FormatarDataParaBancoDeDados(string data)
        {
            DateTime dataRetorno;

            dataRetorno = DateTime.ParseExact(data, "MM/dd/yyyy", null);

            return dataRetorno;
        }
    }
}
