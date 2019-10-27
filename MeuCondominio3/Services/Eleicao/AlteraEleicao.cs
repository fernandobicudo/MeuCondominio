using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Eleicao
{
    public class AlteraEleicao
    {
        public static void EncerrarEleicao(int idEleicao)
        {
            DAOEleicao.EncerrarEleicao(idEleicao);
        }
    }
}
