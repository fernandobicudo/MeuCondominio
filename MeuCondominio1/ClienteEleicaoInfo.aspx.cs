using MeuCondominio2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services.Eleicao;
using MeuCondominio2.Services.Unidade;
using MeuCondominio2.Services.Eleicao.Voto;
using System.Data;

namespace MeuCondominio1
{
    public partial class CondominoEleicaoInfo : System.Web.UI.Page
    {
        List<OpcaoDeVotacaoPlebiscito> listaDeOpcoesParaVotar = new List<OpcaoDeVotacaoPlebiscito>();
        OpcaoDeVotacaoPlebiscito opcaoDeVotacaoPlebiscito;
        Eleicao eleicao;
        DataTable dtEleicao;
        DataTable dtOpcoesDaEleicao;
        Label tituloEleicao = new Label();
        Label lbtipoEleicao = new Label();
        Label tipoEleicao = new Label();
        Label lbDescricaoEleicao = new Label();
        Label descricaoEleicao = new Label();
        Label lbStatusEleicao = new Label();
        Label statusEleicao = new Label();
        Label lbDataInicioEleicao = new Label();
        Label dataInicioEleicao = new Label();
        Label lbDataFimEleicao = new Label();
        Label dataFimEleicao = new Label();
        RadioButtonList radioButonsComOpcoesParaVotar = new RadioButtonList();
        Voto voto;
        int idUnidade;


        protected void Page_Load(object sender, EventArgs e)
        {
            RecuperaDadosDaEleicao();
            CriarObjetoEleicao();
            CriarListaDeOpcoesParaVotar();
            //PreencheFormularioComDadosDaEleicao();
            PreparaFormularioSobreEleicao(eleicao);
        }

        private void AlternarPaginaParaTipoEleicao(Eleicao eleicao)
        {
            string tipoVotacao;

            tipoVotacao = eleicao.GetTipoEleicao();

            switch (tipoVotacao)
            {
                case "Plebiscito":
                    IncluirCamposDePlebiscito();
                    break;
                case "Projetos e Serviços Prediais":
                    IncluirCamposDeServicoASerVotado();
                    break;
                case "Eleição para Síndico":
                    IncluirCamposDeCandidatoASindico();
                    break;
                default:
                    NenhumTipoSelecionado(); //TODO: implementar validacao para AdicionarOpcaoDeVotacao somente depois de escolher um tipo de votação.
                    break;
            }
        }


        private void PreparaFormularioSobreEleicao(Eleicao eleicao)
        {
            string nomeStatusEleicao;

            tituloEleicao.Attributes.Add("runat", "server");
            tituloEleicao.Text = eleicao.GetNomeEleicao();


            lbtipoEleicao.Attributes.Add("runat", "server");
            lbtipoEleicao.Text = "Tipo de votação: ";
            tipoEleicao.Attributes.Add("runat", "server");
            tipoEleicao.Text = eleicao.GetTipoEleicao();
            lbDescricaoEleicao.Attributes.Add("runat", "server");
            lbDescricaoEleicao.Text = "Descrição: ";
            descricaoEleicao.Attributes.Add("runat", "server");
            descricaoEleicao.Text = eleicao.GetDescricaoEleicao();
            lbStatusEleicao.Attributes.Add("runat", "server");
            lbStatusEleicao.Text = "Situação: ";

            if (eleicao.GetStatusEleicao())
                nomeStatusEleicao = "Em andamento";
            else
                nomeStatusEleicao = "Concluída";

            statusEleicao.Attributes.Add("runat", "server");
            statusEleicao.Text = nomeStatusEleicao;

            lbDataInicioEleicao.Attributes.Add("runat", "server");
            lbDataInicioEleicao.Text = "Início: ";
            dataInicioEleicao.Attributes.Add("runat", "server");
            dataInicioEleicao.Text = eleicao.GetDataInicioEleicao().ToString();
            lbDataFimEleicao.Attributes.Add("runat", "server");
            lbDataFimEleicao.Text = "Realização: ";
            dataFimEleicao.Attributes.Add("runat", "server");
            dataFimEleicao.Text = eleicao.GetDataFimEleicao().ToString();

            pnVotacaoInfo.Controls.Add(tituloEleicao);
            pnVotacaoInfo.Controls.Add(new LiteralControl("<br />"));
            pnVotacaoInfo.Controls.Add(lbtipoEleicao);
            pnVotacaoInfo.Controls.Add(tipoEleicao);
            pnVotacaoInfo.Controls.Add(new LiteralControl("<br />"));
            pnVotacaoInfo.Controls.Add(lbDescricaoEleicao);
            pnVotacaoInfo.Controls.Add(descricaoEleicao);
            pnVotacaoInfo.Controls.Add(new LiteralControl("<br />"));
            pnVotacaoInfo.Controls.Add(lbStatusEleicao);
            pnVotacaoInfo.Controls.Add(statusEleicao);
            pnVotacaoInfo.Controls.Add(new LiteralControl("<br />"));
            pnVotacaoInfo.Controls.Add(lbDataInicioEleicao);
            pnVotacaoInfo.Controls.Add(dataInicioEleicao);
            pnVotacaoInfo.Controls.Add(new LiteralControl("<br />"));
            pnVotacaoInfo.Controls.Add(lbDataFimEleicao);
            pnVotacaoInfo.Controls.Add(dataFimEleicao);
            pnVotacaoInfo.Controls.Add(new LiteralControl("<br />"));

            PreparaRadioButtonsParaVotar();
        }

        private void PreparaRadioButtonsParaVotar()
        {
            foreach(OpcaoDeVotacaoPlebiscito item in listaDeOpcoesParaVotar)
            {
                ListItem listItem = new ListItem(item.GetNomeOpcaoDeVotacaoPlebiscito());
                radioButonsComOpcoesParaVotar.Items.Add(listItem);
            }

            pnVotacaoInfo.Controls.Add(radioButonsComOpcoesParaVotar);
            //pnVotacaoInfo.Controls.Add(new LiteralControl("<br />"));
        }

        private void RecuperaDadosDaEleicao()
        {
            dtEleicao = BuscaEleicao.BuscaEleicaoSelecionadaDoCondominio(Convert.ToInt32(Request["codigoEleicao"]));
        }

        private void CriarObjetoEleicao()
        {
            eleicao = new Eleicao(Convert.ToInt32(dtEleicao.Rows[0]["idEleicao"]),
                dtEleicao.Rows[0]["nomeEleicao"].ToString(),
                dtEleicao.Rows[0]["descricaoEleicao"].ToString(),
                dtEleicao.Rows[0]["tipoEleicao"].ToString(),
                Convert.ToBoolean(dtEleicao.Rows[0]["statusEleicao"]),
                Convert.ToDateTime(dtEleicao.Rows[0]["dataInicioEleicao"]),
                Convert.ToDateTime(dtEleicao.Rows[0]["dataFimEleicao"]),
                Convert.ToInt32(dtEleicao.Rows[0]["idCondominio"]));
        }

        private OpcaoDeVotacaoPlebiscito CriarObjetoOpcaoDeVotacaoPlebiscito(DataRow linha)
        {
            opcaoDeVotacaoPlebiscito = new OpcaoDeVotacaoPlebiscito(
                Convert.ToInt32(linha["idOpcaoVotadaPlebiscito"]),
                linha["nomeOpcaoVotada"].ToString(),
                Convert.ToInt32(linha["idEleicao"]));

            return opcaoDeVotacaoPlebiscito;
        }

        private void CriarListaDeOpcoesParaVotar()
        {
            dtOpcoesDaEleicao = BuscaEleicao.BuscaOpcoesVotacao(eleicao.GetIdEleicao());

            foreach(DataRow linha in dtOpcoesDaEleicao.Rows)
            {
                listaDeOpcoesParaVotar.Add(CriarObjetoOpcaoDeVotacaoPlebiscito(linha));
            }
        }

        private void PreencheFormularioComDadosDaEleicao()
        {
            tituloEleicao.Text = dtEleicao.Rows[0]["nomeEleicao"].ToString();
            descricaoEleicao.Text = dtEleicao.Rows[0]["descricaoEleicao"].ToString();
            dataInicioEleicao.Text = dtEleicao.Rows[0]["dataInicioEleicao"].ToString();
            dataFimEleicao.Text = dtEleicao.Rows[0]["dataFimEleicao"].ToString();
        }

        private void NenhumTipoSelecionado()
        {
            throw new NotImplementedException();
        }

        private void IncluirCamposDeCandidatoASindico()
        {
            throw new NotImplementedException();
        }

        private void IncluirCamposDeServicoASerVotado()
        {
            throw new NotImplementedException();
        }

        private void IncluirCamposDePlebiscito()
        {
            throw new NotImplementedException();
        }

        protected void bt_Votar_Click(object sender, EventArgs e)
        {
            BuscaDadosDaOpcaoVotada();
            BuscaUnidadeDoCondominoNoCondominio();
            ConstruirObjetoVoto();
            GravaVoto.GravaVotoDaEleicao(voto);
        }


        private void BuscaDadosDaOpcaoVotada()
        {
            DataTable dtEleicao;
            string nomeOpcaoVotada = radioButonsComOpcoesParaVotar.SelectedValue.ToString();
            dtEleicao = BuscaEleicao.BuscaOpcaoVotada(nomeOpcaoVotada, eleicao.GetIdEleicao());
            opcaoDeVotacaoPlebiscito = CriarObjetoOpcaoDeVotacaoPlebiscito(dtEleicao.Rows[0]);
        }

        private void BuscaUnidadeDoCondominoNoCondominio()
        {
            DataTable dtUnidade;
            dtUnidade = BuscaUnidade.BuscarUnidadePorCondominoDoCondominio(
            Convert.ToInt32((Session["codigoUser"])), Convert.ToInt32((Session["codigoCondominio"])));
            //TODO: RESOLVER O CASO EM QUE O CONDOMINO TEM N UNIDADES: terá direito a N votos, porém a tendência é que vote na mesma opção em todos os votos;
            idUnidade = Convert.ToInt32(dtUnidade.Rows[0]["idUnidade"]);
        }

        private void ConstruirObjetoVoto()
        {
            voto = new Voto(opcaoDeVotacaoPlebiscito.GetIdOpcaoDeVotacaoPlebiscito(), eleicao.GetIdEleicao(), idUnidade);
        }
    }
}