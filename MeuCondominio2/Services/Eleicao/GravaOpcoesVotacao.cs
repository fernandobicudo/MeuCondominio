using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.DAO;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.Eleicao
{
    public class GravaOpcoesVotacao
    {
        public void GravaOpcoesDeVotacaoDaEleicaoDePlebiscito(List<string> listaOpcoesVotacao)
        {
            DAOOpcaoVotacao.InserirOpcoesVotacaoPlebiscito(listaOpcoesVotacao);
        }
    }
}
