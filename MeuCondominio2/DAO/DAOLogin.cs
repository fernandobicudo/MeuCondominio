using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MeuCondominio2.DAO
{
    class DAOLogin
    {
        public static DataTable SelecionarLogin(string email)
        {
            DataTable dt;
            string sql = "select * from usuario where email = '" + email + "';";
            dt = MetodosBD.ExecutaSelect(sql);
            return dt;
        }
/*        public static Login CriarObjetoLogin(DataTable dt)
        {
            Login login = new Login();

            login.SetEmail(dt.Rows[0]["email"].ToString());
            login.SetSenha(dt.Rows[0]["senha"].ToString());

            return login;
        }*/
    }
}
