using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;

namespace MeuCondominio2.DAO
{
    public class DAOOpcaoVotacao
    {
        public static void InserirOpcoesVotacaoPlebiscito (List<string> listaOpcoesVotacao)
        {
            string SQL;

            int ultimaEleicao;

            ultimaEleicao = DAOEleicao.PesquisarIdDaUltimaEleicaoRegistrada();
            
            //TODO: eliminar risco de inserir id de outra eleição nas chaves estrangeiras das opções da eleição.

            foreach (string opcaoVotacao in listaOpcoesVotacao)
            {
                SQL = String.Format(@"INSERT INTO `OpcaoDeVotoPlebiscito` " +
                    "(`nomeOpcaoVotada`, `idEleicao`) " +
                    "VALUES ('{0}', {1});",
                    opcaoVotacao, ultimaEleicao);

                MetodosBD.ExecutaSQL(SQL);
            }
        }
    }
}
