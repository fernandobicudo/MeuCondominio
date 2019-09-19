using MeuCondominio2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuCondominio1
{
    public partial class CondominoEleicaoInfo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

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


        private void ExibirInfoSobreAEleicao(Eleicao eleicao)
        {
            string nomeStatusEleicao;

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


            tituloEleicao.Text = eleicao.GetNomeEleicao();
            lbtipoEleicao.Text = "Tipo de votação: ";
            tipoEleicao.Text = eleicao.GetTipoEleicao();
            lbDescricaoEleicao.Text = "Descrição: ";
            descricaoEleicao.Text = eleicao.GetDescricaoEleicao();
            lbStatusEleicao.Text = "Situação: ";


            if (eleicao.GetStatusEleicao())
                nomeStatusEleicao = "Em andamento";
            else
                nomeStatusEleicao = "Concluída";

            statusEleicao.Text = nomeStatusEleicao;

            lbDataInicioEleicao.Text = "Início: ";
            dataInicioEleicao.Text = eleicao.GetDataInicioEleicao().ToString();
            lbDataFimEleicao.Text = "Realização: ";
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

    }

    
}