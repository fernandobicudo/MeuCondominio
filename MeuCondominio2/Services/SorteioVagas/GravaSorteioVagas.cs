using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.DAO;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.SorteioVagas
{
    public class GravaSorteioVagas
    {
        public static void GravarSorteioVagas(Model.SorteioVagas sorteioVagas)
        {
            DAOSorteioVagas.InserirSorteioVagas(sorteioVagas);
        }
    }
}
