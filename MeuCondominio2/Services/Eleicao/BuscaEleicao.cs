using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Eleicao
{
    public class BuscaEleicao
    {
        public static DataTable BuscaEleicoesDoCondominio(int idCondominio)
        {
            DataTable dt;
            dt = DAOEleicao.PesquisarEleicoesDoCondominio(idCondominio);
            return dt;
        }
    }
}
