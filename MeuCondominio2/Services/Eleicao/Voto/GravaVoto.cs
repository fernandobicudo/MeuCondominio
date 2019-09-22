using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.DAO;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.Eleicao.Voto
{
    public class GravaVoto
    {
        public static void GravaVotoDaEleicao(Model.Voto voto)
        {
            DAOVoto.InserirVotoDaEleicao(voto);
        }
    }
}
