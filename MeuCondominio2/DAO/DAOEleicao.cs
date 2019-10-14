using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;



namespace MeuCondominio2.DAO
{
    class DAOEleicao
    {
        public static DataTable PesquisarEleicoesDoCondominio(int idCondominio)
        {
            string SQL = String.Format(@"SELECT * FROM `Eleicao`  " +
                "WHERE idCondominio = {0};", idCondominio);
            return MetodosBD.ExecutaSelect(SQL);
        }

        public static DataTable PesquisarEleicaoSelecionadaDoCondominio(int idEleicao)
        {
            string SQL = String.Format(@"SELECT * FROM `Eleicao`  " +
                "WHERE idEleicao = {0};", idEleicao);
            return MetodosBD.ExecutaSelect(SQL);
        }

        public static DataTable PesquisarOpcoesdeVotacaoDaEleicao(int idEleicao)
        {
            string SQL = String.Format(@"SELECT * FROM `OpcaoDeVotoPlebiscito`" +
                "WHERE idEleicao = {0};", idEleicao);
            return MetodosBD.ExecutaSelect(SQL);
        }

        public static int PesquisarIdDaUltimaEleicaoRegistrada()
        {
            int idEleicao;
            DataTable dt;

            string SQL = String.Format(@"SELECT MAX(idEleicao) as idEleicao FROM `Eleicao`;");
            dt = MetodosBD.ExecutaSelect(SQL);
            idEleicao = Convert.ToInt32(dt.Rows[0]["idEleicao"]);
            return idEleicao;
        }

        public static int PesquisarIdDaUltimaEleicaoRegistradaDoCondomminio(int idCondominio)
        {
            int idEleicao;
            DataTable dt;

            string SQL = String.Format(@"SELECT MAX(idEleicao) as idEleicao FROM `Eleicao` " +
                "WHERE idCondominio = {0};", idCondominio);
            dt = MetodosBD.ExecutaSelect(SQL);
            idEleicao = Convert.ToInt32(dt.Rows[0]["idEleicao"]);
            return idEleicao;
        }

        internal static DataTable PesquisarOpcaoVotadaDaEleicao(string nomeOpcaoVotada, int idEleicao)
        {
            string SQL = String.Format(@"SELECT * FROM `opcaoDeVotoPlebiscito` vp " +
                "JOIN `Eleicao` el ON el.idEleicao = vp.idEleicao " +
                "WHERE el.idEleicao = {0} " +
                "AND vp.nomeOpcaoVotada = '{1}';", idEleicao, nomeOpcaoVotada);
            return MetodosBD.ExecutaSelect(SQL);
        }

        public static void InserirEleicao(Eleicao eleicao)
        {
            string SQL;

            string dataInicioEleicao = Formatadores.ConversaoDeDataParaStringMySQL(eleicao.GetDataInicioEleicao());
            string dataFimEleicao = Formatadores.ConversaoDeDataParaStringMySQL(eleicao.GetDataFimEleicao());
            byte status = Formatadores.FormatarBooleanParaMySQL(eleicao.GetStatusEleicao());

            SQL = String.Format(@"INSERT INTO `Eleicao` " +
                "(`nomeEleicao`, `tipoEleicao`, `descricaoEleicao`, " +
                "`statusEleicao`, `dataInicioEleicao`, `dataFimEleicao`, `idCondominio`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6});",
                eleicao.GetNomeEleicao(), eleicao.GetTipoEleicao(), eleicao.GetDescricaoEleicao(),
                status, dataInicioEleicao, dataFimEleicao, eleicao.GetIdCondominio());

            MetodosBD.ExecutaSQL(SQL);
        }

        public static void EncerrarEleicao(int idEleicao)
        {
            string SQL = String.Format(@"UPDATE `Eleicao` SET `statusEleicao` = false WHERE idEleicao = {0}; ", idEleicao);
            MetodosBD.ExecutaSQL(SQL);
        }
    }
}
