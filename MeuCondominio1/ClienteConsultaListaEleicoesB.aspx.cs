using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Eleicao;

namespace MeuCondominio1
{
    public partial class ClienteConsultaListaEleicoesB : System.Web.UI.Page
    {
        List<Eleicao> listaDeEleicoesDoCondominio = new List<Eleicao>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["RefUrl"] = Request.UrlReferrer.ToString();
                /*CarregarGriView();*/
            }
            ConstruirListaDeEleicoes();
        }

        private void CarregarGriView()
        {
            gvEleicoes.DataSource = listaDeEleicoesDoCondominio;

        }

        private void ListarEleicoesNaPagina()
        {
            foreach (Eleicao eleicao in listaDeEleicoesDoCondominio)
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

                pnEleicoes.Controls.Add(tituloEleicao);
                pnEleicoes.Controls.Add(new LiteralControl("<br />"));
                pnEleicoes.Controls.Add(lbtipoEleicao);
                pnEleicoes.Controls.Add(tipoEleicao);
                pnEleicoes.Controls.Add(new LiteralControl("<br />"));
                pnEleicoes.Controls.Add(lbDescricaoEleicao);
                pnEleicoes.Controls.Add(descricaoEleicao);
                pnEleicoes.Controls.Add(new LiteralControl("<br />"));
                pnEleicoes.Controls.Add(lbStatusEleicao);
                pnEleicoes.Controls.Add(statusEleicao);
                pnEleicoes.Controls.Add(new LiteralControl("<br />"));
                pnEleicoes.Controls.Add(lbDataInicioEleicao);
                pnEleicoes.Controls.Add(dataInicioEleicao);
                pnEleicoes.Controls.Add(new LiteralControl("<br />"));
                pnEleicoes.Controls.Add(lbDataFimEleicao);
                pnEleicoes.Controls.Add(dataFimEleicao);
            }
        }
        //TODO: pensar numa maneira de clicar numa linha de Eleição e levar à página de detalhe (votação ou consulta, dependendo do status da eleição)


        private void ConstruirListaDeEleicoes()
        {
            DataTable dt;

            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
            BuscaEleicao buscaEleicao = new BuscaEleicao();
            dt = buscaEleicao.BuscaEleicoesDoCondominio(idCondominio);

            gvEleicoes.DataSource = dt;

            gvEleicoes.DataBind();

            /*foreach (DataRow linha in dt.Rows)
            {
                eleicao = new Eleicao(Convert.ToInt32(linha["idEleicao"].ToString()),
                    linha["nomeEleicao"].ToString(),
                    linha["descricaoEleicao"].ToString(),
                    linha["nomeTipoEleicao"].ToString(),
                    Convert.ToBoolean(linha["statusEleicao"]),
                    Convert.ToDateTime(linha["dataInicioEleicao"].ToString()),
                    Convert.ToDateTime(linha["dataFimEleicao"].ToString()),
                    Convert.ToInt32(linha["idCondominio"].ToString()));

                listaDeEleicoesDoCondominio.Add(eleicao);
            }*/
        }

        protected void GridView_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';";
                /*                e.Row.Attributes["onmouseout"] = "this.style.fontWeight='normal';";*/
                e.Row.ToolTip = "Clique na linha para selecioná-la.";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.gvEleicoes, "Select$" + e.Row.RowIndex);
            }
        }

        protected void GridView_SelectedIndex_Changed(object sender, EventArgs e)
        {
            string idEleicao = gvEleicoes.SelectedRow.Cells[0].Text;
            string tituloEleicao = gvEleicoes.SelectedRow.Cells[1].Text;


            bool status = Convert.ToBoolean(gvEleicoes.SelectedRow.Cells[3].Text); ;

            if (status)
                Response.Redirect(String.Format(@"CondominoEleicaoInfo.aspx?modo={0}&codigoEleicao={1}",
                    0, idEleicao));
            else
                Response.Redirect(String.Format(@"CondominoResultadoDaEleicao.aspx?modo={0}&codigoEleicao={1}&tituloEleicao={2}",
                    0, idEleicao, tituloEleicao));
        }

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            object refUrl = ViewState["RefUrl"];
            if (refUrl != null)
                Response.Redirect((string)refUrl);
        }
    }
}