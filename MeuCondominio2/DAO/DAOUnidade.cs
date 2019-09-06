using MeuCondominio2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.DAO
{
    class DAOUnidade
    {

        public static DataTable SelecionarUnidade()
        {
            DataTable dt;
            string SQL;
            SQL = "SELECT * FROM `Unidade`;";
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        public static DataTable SelecionarUnidade(int id)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `Unidade` WHERE id={0};", id);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        internal static int ContarUnidadesPorCondominio(int idCondominio)
        {
            DataTable dt;
            int contagem;

            string SQL;
            SQL = String.Format(@"SELECT COUNT(*) FROM `Unidade` WHERE `idCondominio` = {0};", idCondominio);
            dt =  MetodosBD.ExecutaSelect(SQL);
            contagem = Convert.ToInt32(dt.Rows[0]["count(*)"].ToString());
            return contagem;
        }

        
        public static DataTable SelecionarUnidadePorCondominio(int idCondominio)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `Unidade` WHERE idCondominio={0};", idCondominio);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }
    }
}
