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

        public static DataTable BuscaEleicaoSelecionadaDoCondominio(int idEleicao)
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

        public static DataTable BuscaOpcoesVotacao(int idEleicao)
        {
            DataTable dt;
            dt = DAOEleicao.PesquisarOpcoesdeVotacaoDaEleicao(idEleicao);
            return dt;
        }

        public static DataTable BuscaOpcaoVotada(string nomeOpcaoVotada, int idEleicao)
        {
            DataTable dt;
            dt = DAOEleicao.PesquisarOpcaoVotadaDaEleicao(nomeOpcaoVotada, idEleicao);
            return dt;
        }

        public static int BuscaIdDaUltimaEleicaoDoCondominio(int idCondominio)
        {
            int idEleicao;
            idEleicao = DAOEleicao.PesquisarIdDaUltimaEleicaoRegistradaDoCondomminio(idCondominio);
            return idEleicao;
        }
    }
}
