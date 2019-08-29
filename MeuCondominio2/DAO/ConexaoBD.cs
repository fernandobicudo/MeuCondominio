using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace MeuCondominio2.DAO
{
    public class ConexaoBD
    {
        /*        public static MySqlConnection GetConexao()
                {
                    string sc = "Server=localhost;Database=MeuCondominio;Uid=root;Pwd=123456;"; 
                    MySqlConnection conexao = new MySqlConnection(sc);
                    conexao.Open();
                    return conexao;
                }
        */
        public static SQLiteConnection GetConexaoSQLite()
        {

            /*TODO: Implementar caminho relativo para BD SQLite portável*/
            /* string pathToSQLiteBD;
           pathToSQLiteBD = Path.Combine(new FileInfo(typeof(ConexaoBD).Assembly.Location).DirectoryName, "Condominio.db3");
*/
            string sc = "Data Source=C:\\Users\\LUISFERNANDOMARTINSB\\source\\repos\\MeuCondominio1\\MeuCondominio2\\Condominio.db3;Version=3";
            SQLiteConnection conexao = new SQLiteConnection(sc);
            conexao.Open();
            return conexao;
        }
    }
}
