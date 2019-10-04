using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.DAO
{
    class DAOCondominio
    {
        public static DataTable PesquisarCondominioPorIddoCondomino(int idCondomino)
        {
            DataTable dt;
            string SQL;

            SQL = String.Format(@"SELECT * FROM `Condominio` co " +
                "JOIN `Unidade` un ON un.idCondominio = co.id " +
                "JOIN `Usuario` us ON us.id_usuario = un.idCondomino " +
                "WHERE us.id_usuario = {0};", idCondomino);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        public static DataTable PesquisarCondominioPorIdDoCondominio(int idCondominio)
        {
            DataTable dt;
            string SQL;

            SQL = String.Format(@"SELECT * FROM `Condominio` WHERE id = {0}", idCondominio);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }
    }
}
