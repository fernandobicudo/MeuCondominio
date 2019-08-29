using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace MeuCondominio2.DAO
{
    public class MetodosBD
    {
        /*        public static DataTable ExecutaSelectMySQL(string sql) 
                {
                    MySqlConnection conexao = ConexaoBD.GetConexao();
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                        DataTable dataTemp = new DataTable();
                        adapter.Fill(dataTemp);
                        return dataTemp;
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
        */

        public static DataTable ExecutaSelectSQLite(string sql)
        {
            SQLiteConnection conexao = ConexaoBD.GetConexaoSQLite();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexao);
                DataTable dataTemp = new DataTable();
                adapter.Fill(dataTemp);
                return dataTemp;
            }
            finally
            {
                conexao.Close();
            }
        }

        /*        public static void ExecutaSQLMySQL(string sql)
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
                }*/

        public static void ExecutaSQLite(string sql)
        {
            SQLiteConnection conexao = ConexaoBD.GetConexaoSQLite();
            try
            {
                SQLiteCommand comando = new SQLiteCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
