using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace MeuCondominio2.DAO
{
    public class MetodosBD
    {
        public static DataTable ExecutaSelect(string sql)
        {
            MySqlConnection conexao = ConexaoBD.GetConexao();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                DataTable dataTemp = new DataTable();
                adapter.Fill(dataTemp);
                adapter.Dispose();
                return dataTemp;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void ExecutaSQL(string sql)
        {
            MySqlConnection conexao = ConexaoBD.GetConexao();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
