using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Eleicao.Voto
{
    public class BuscaVotos
    {
        public static DataTable BuscaQtdesDeVotosParaCadaOpcaoDaEleicao(int idEleicao)
        {
            DataTable dt;
            dt = DAOVoto.SelecionarOpcoesDeVotosESuasQuantidadesDeVotosNaEleicao(idEleicao);
            return dt;
        }
    }
}
