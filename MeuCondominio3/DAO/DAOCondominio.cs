using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.DAO
{
    class DAOCondominio
    {
        public static DataTable PesquisarCondominioPorIdDoCliente(int idCliente)
        {
            DataTable dt;
            string SQL;

            SQL = String.Format(@"SELECT * FROM `Condominio` co " +
                "JOIN `Unidade` un ON un.idCondominio = co.idCondominio " +
                "JOIN `Usuario` us ON us.idUsuario = un.idCliente " +
                "WHERE us.idUsuario = {0};", idCliente);
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
