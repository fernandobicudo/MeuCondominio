using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Eleicao
{
    public class BuscaEleicao
    {
        public DataTable BuscaEleicoesDoCondominio(int idCondominio)
        {
            DataTable dt;
            dt = DAOEleicao.PesquisarEleicoesDoCondominio(idCondominio);
            return dt;
        }

        public DataTable BuscaEleicaoSelecionadaDoCondominio(int idEleicao)
        {
            DataTable dt;
            dt = DAOEleicao.PesquisarEleicaoSelecionadaDoCondominio(idEleicao);
            return dt;
        }

        /*        SELECT INCORRETO, ESTÁ BUSCANDO POR CONDOMINIO QUANDO O DAO NA VERDADE BUSCA POR ELEICAO: NÃO ESTÁ SENDO CHAMADO POR NINGUÉM
         *        public static DataTable BuscaEleicoesDoCondominioComOpcoesDeVotacao(int idCondominio)
                {
                    DataTable dt;
                    dt = DAOEleicao.PesquisarOpcoesdeVotacaoDaEleicao(idCondominio);
                    return dt;
                }*/

        public DataTable BuscaOpcoesVotacao(int idEleicao)
        {
            DataTable dt;
            dt = DAOEleicao.PesquisarOpcoesdeVotacaoDaEleicao(idEleicao);
            return dt;
        }

        public DataTable BuscaOpcaoVotada(string nomeOpcaoVotada, int idEleicao)
        {
            DataTable dt;
            dt = DAOEleicao.PesquisarOpcaoVotadaDaEleicao(nomeOpcaoVotada, idEleicao);
            return dt;
        }

        public int BuscaIdDaUltimaEleicaoDoCondominio(int idCondominio)
        {
            int idEleicao;
            idEleicao = DAOEleicao.PesquisarIdDaUltimaEleicaoRegistradaDoCondomminio(idCondominio);
            return idEleicao;
        }
    }
}
