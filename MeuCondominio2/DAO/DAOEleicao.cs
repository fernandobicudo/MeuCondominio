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
            DataTable dt;
            string SQL = String.Format(@"SELECT * FROM `Eleicao`  " +
                "WHERE idCondominio = {0};", idCondominio);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }

        public static DataTable PesquisarEleicoesDoCondominioComOpcoesdeVotacao(int idCondominio)
        {
            DataTable dt;
            string SQL = String.Format(@"SELECT * FROM `Eleicao` el " +
                "JOIN `OpcaoDeVotoPlebiscito` op ON op.idEleicao = el.idEleicao " +
                "WHERE idCondominio = {0};", idCondominio);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
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


        public static void InserirEleicao(Eleicao eleicao)
        {
            string SQL;

            string dataInicioEleicao = Formatadores.ConversaoDeDataParaString(eleicao.GetDataInicioEleicao());
            string dataFimEleicao = Formatadores.ConversaoDeDataParaString(eleicao.GetDataFimEleicao()); 

            SQL = String.Format(@"INSERT INTO `Eleicao` " +
                "(`nomeEleicao`, `tipoEleicao`, `descricaoEleicao`, " + 
                "`statusEleicao`, `dataInicioEleicao`, `dataFimEleicao`, `idCondominio`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6});", 
                eleicao.GetNomeEleicao(), eleicao.GetTipoEleicao(), eleicao.GetDescricaoEleicao(),
                eleicao.GetStatusEleicao(), dataInicioEleicao, dataFimEleicao, eleicao.GetIdCondominio());

            MetodosBD.ExecutaSQL(SQL);
        }
    }
}
