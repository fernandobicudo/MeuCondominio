using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace MeuCondominio2.DAO
{
    public class ConexaoBD
    {
        public static MySqlConnection GetConexao()
        {
            string sc = MeuCondominio2.Properties.Settings.Default.ConnectionString;
            MySqlConnection conexao = new MySqlConnection(sc);
            conexao.Open();
            return conexao;
        }
    }
}
