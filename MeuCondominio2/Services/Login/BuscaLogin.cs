using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.DAO;
using System.Data;

namespace MeuCondominio2.Services.Login
{
    public class BuscaLogin
    {
        public DataTable PesquisarLogin(string email)
        {
            return DAOLogin.SelecionarLogin(email);
        }
    }
}
