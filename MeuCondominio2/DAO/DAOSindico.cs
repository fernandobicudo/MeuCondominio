using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.DAO
{
    class DAOSindico
    {
        public static DataTable SelecionarSindico(int idSindico)
        {

            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `Sindico` WHERE `idSindico`= {0};", idSindico);
            dt = MetodosBD.ExecutaSelect(SQL);

            return dt;
        }
    }
}
