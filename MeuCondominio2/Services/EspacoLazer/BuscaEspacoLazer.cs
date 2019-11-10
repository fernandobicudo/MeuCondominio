using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeuCondominio2.DAO;
using System.Data;

namespace MeuCondominio2.Services.EspacoLazer
{
    public class BuscaEspacoLazer
    {
        public DataTable BuscarEspacoLazer(string nomeEspaco)
        {
            DataTable dt;
            dt = DAOEspacoLazer.PesquisarEspacoLazerPorNome(nomeEspaco);
            return dt;
        }
    }
}