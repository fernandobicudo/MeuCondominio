using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Services.Ferramentas
{
    public class Formatadores
    {
        public static String ConversaoDeDataParaStringMySQL(DateTime data)
        {
            string formatForMySql = data.ToString("yyyy-MM-dd HH:mm:ss");
            return formatForMySql;
        }

        public static DateTime ConversaoDeStringMySQLParaDateTime(string data)
        {
            data = data.Replace('/', ',');
            data = data.Replace(':', ',');

            DateTime formatFromMySqlToDateTime = Convert.ToDateTime(data);
            return formatFromMySqlToDateTime;
        }

        public static String ConversaoDeDataParaStringSQLite(DateTime data)
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

        public static byte FormatarBooleanParaMySQL(bool status)
        {
            return Convert.ToByte(status);
        }

        public string FormatarCPFSemPontosNemTracos(string CPF)
        {
            CPF = CPF.Trim();
            CPF = CPF.Replace(".","");
            CPF = CPF.Replace(" ", "");
            CPF = CPF.Replace("-", "");

            return CPF;
        }
    }
}
