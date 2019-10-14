using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace MeuCondominio2.DAO
{
    public class ConexaoBD
    {
        public static MySqlConnection GetConexao()
        {
            string sc = "Server=localhost;Database=MeuCondominio2;Uid=root;Pwd=123456;";
            MySqlConnection conexao = new MySqlConnection(sc);
            conexao.Open();
            return conexao;
        }
    }
}
