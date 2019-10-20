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

        public static DataTable SelecionarUnidade(int idUnidade)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `Unidade` WHERE id={0};", idUnidade);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        public static int SelecionarUnidade(string nomeUnidade)
        {
            int idUnidade;
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT `idUnidade` FROM Unidade WHERE `identificacao` = '{0}'", nomeUnidade);
            dt = MetodosBD.ExecutaSelect(SQL);
            idUnidade = Convert.ToInt32(dt.Rows[0]["idUnidade"]);
            return idUnidade;
        }


        public static DataTable SelecionarUnidadePorCondominoDoCondominio(int idCliente, int idCondominio)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `Unidade` un " +
                "JOIN  `Cliente` cli ON cli.idCliente = un.idCliente " +
                "JOIN  `Condominio` cio ON cio.idCondominio = un.idCondominio " +
                "WHERE cli.idCliente={0} AND cio.idCondominio={1};", idCliente, idCondominio);
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
