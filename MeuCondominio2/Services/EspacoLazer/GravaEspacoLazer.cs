using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeuCondominio2.DAO;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.EspacoLazer
{
    public class GravaEspacoLazer
    {
        public void  GravarEspacoLazer(Model.EspacoLazer espacoLazer)
        {
            DAOEspacoLazer.InserirEspacoLazer(espacoLazer);
        }
    }
}