using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.DAO;
using System.Data;

namespace MeuCondominio2.Services
{
    public class BuscaLogin
    {
        public static DataTable buscaLogin(string email)
        {
            return DAOLogin.PesquisarLogin(email);
        }
    }
}
