using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services;

namespace MeuCondominio2.DAO
{
    public class DAOVoto
    {
        public static void InserirVotoDaEleicao(Voto voto)
        {
            string SQL = String.Format(@"INSERT INTO `Voto` (`idOpcaoVotada`, `idEleicao`, `idUnidade`) " +
                "VALUES ({0}, {1}, {2});", voto.IdOpcaoVotada, voto.IdEleicao, voto.IdUnidade);
            MetodosBD.ExecutaSQL(SQL);
        }

        private static DataTable SelecionarQuantidadesDeVotosParaCadaOpcaoDaEleicao(int idOpcaoVotada)
        {
            DataTable dt;
            string SQL = String.Format(@"SELECT vp.nomeOpcaoVotada, count(vo.idOpcaoVotada) As QtdVotos FROM `Voto` vo " +
                                        "JOIN `Eleicao` el ON el.idEleicao = vo.idEleicao " +
                                        "JOIN opcaoDeVotoPlebiscito vp ON vp.idOpcaoVotadaPlebiscito = vo.idOpcaoVotada " +
                                        "WHERE VP.idOpcaoVotadaPlebiscito = {0};", idOpcaoVotada);
            //TODO: o select está trazendo o nome nulo da opção quando ela tem zero voto. Encontrar solução e corrigir.

            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        public static DataTable SelecionarOpcoesDeVotosESuasQuantidadesDeVotosNaEleicao(int idEleicao)
        {
            DataTable dtQuantidadesDeVotosParaCadaOpcaoDaEleicao = new DataTable();

            
            DataTable dtOpcoesDeVotoDaEleicao;

            dtOpcoesDeVotoDaEleicao = DAOEleicao.PesquisarOpcoesdeVotacaoDaEleicao(idEleicao);

            dtQuantidadesDeVotosParaCadaOpcaoDaEleicao.Columns.Add("nomeOpcaoVotada");
            dtQuantidadesDeVotosParaCadaOpcaoDaEleicao.Columns.Add("QtdVotos");

            foreach (DataRow linha in dtOpcoesDeVotoDaEleicao.Rows)
            {
                int idOpcao = Convert.ToInt32(linha["idOpcaoVotadaPlebiscito"]);
                dtQuantidadesDeVotosParaCadaOpcaoDaEleicao.ImportRow(SelecionarQuantidadesDeVotosParaCadaOpcaoDaEleicao(idOpcao).Rows[0]);
            }
            return dtQuantidadesDeVotosParaCadaOpcaoDaEleicao;
        }
    }
}
