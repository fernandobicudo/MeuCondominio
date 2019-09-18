using System;
using System.Collections.Generic;
using System.Data;
using System.Text;



namespace MeuCondominio2.DAO
{
    class DAOEleicao
    {
        public static DataTable PesquisarEleicoesDoCondominio(int idCondominio)
        {
            DataTable dt;
            string SQL = String.Format(@"SELECT * FROM `Eleicao` el " +
                "JOIN `TipoEleicao` te ON te.idEleicao = el.idEleicao " +
                "WHERE idCondominio = {0};", idCondominio);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }
    }
}
