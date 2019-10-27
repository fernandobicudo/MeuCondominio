using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.DAO
{
    public class DAOVagaGaragem
    {
        public static DataTable SelecionarVagaGaragem()
        {
            DataTable dt;
            string SQL;
            SQL = "SELECT * FROM `vagaGaragem`;";
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        public static DataTable SelecionarVagaGaragem(int id)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `vagaGaragem` WHERE id={0};", id);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        public static DataTable SelecionarVagasGaragemPorCondominio(int idCondominio)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `vagaGaragem` vg "+
                "JOIN `Unidade` un ON un.idUnidade = vg.idUnidade " +
                "WHERE un.idCondominio = {0} " +
                "ORDER BY vg.idVagaGaragem;", idCondominio); //TODO: atualizar idUnidade para idCondominio quando estiver atualizado no banco.
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }
    }
}
