using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MeuCondominio2.DAO;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.EspacoLazer
{
    public class BuscaReservaEspacoLazer
    {
        public DataTable BuscarReservaEspacoLazer(int idUsuario, int idCondominio)
        {
            DataTable dt;

            dt = DAOReservaEspacoLazer.PesquisarReservaEspacoLazer(idUsuario, idCondominio);

            return dt;
        }
    }
}