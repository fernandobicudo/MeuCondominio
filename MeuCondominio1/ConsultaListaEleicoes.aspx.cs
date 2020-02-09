using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Eleicao;
using MeuCondominio2.Services.Ferramentas;

namespace MeuCondominio1
{
    public partial class ConsultaListaEleicoes : System.Web.UI.Page
    {

        List<Eleicao> listaDeEleicoesDoCondominio = new List<Eleicao>();
        int tipoUsuario;
        string idEleicao;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["RefUrl"] = Request.UrlReferrer.ToString();
                /*CarregarGriView();*/
            }
            tipoUsuario = Convert.ToInt32(Session["tipoUser"]);
            ConfigurarModosDeTela();
            ConstruirListaDeEleicoes();
        }

        private void ConstruirListaDeEleicoes()
        {
            DataTable dt;
            Formatadores formatadores = new Formatadores();

            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
            BuscaEleicao buscaEleicao = new BuscaEleicao();
            dt = buscaEleicao.BuscaEleicoesDoCondominio(idCondominio);

            if (dt.Rows.Count > 0)
            {
                gvEleicoes.DataSource = dt;
                gvEleicoes.DataBind();
            }
            else
            {
                Label lbNaoHaEleicoes = new Label();
                lbNaoHaEleicoes.Text = "Não há votações anteriores em seu condomínio.";
                pnEleicoes.Controls.Add(lbNaoHaEleicoes);
            }

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
            idEleicao = gvEleicoes.SelectedRow.Cells[0].Text;
            string tituloEleicao = gvEleicoes.SelectedRow.Cells[1].Text;


            bool status = Convert.ToBoolean(gvEleicoes.SelectedRow.Cells[2].Text); 

            if (status)
            {
                switch (tipoUsuario)
                {
                    case 6:
                        Response.Redirect(String.Format(@"ClienteEleicaoInfo.aspx?modo={0}&codigoEleicao={1}",
                        0, idEleicao));
                        break;
                    case 2:
                        Response.Redirect(String.Format(@"CadastroEleicao.aspx?modo={0}&codigoEleicao={1}",
                        1, idEleicao));
                        break;
                    default:
                        break;
                }
            }
            else
                switch (tipoUsuario)
                {
                    case 6:
                        Response.Redirect(String.Format(@"ClienteResultadoDaEleicao.aspx?modo={0}&codigoEleicao={1}&tituloEleicao={2}",
                        0, idEleicao, tituloEleicao));
                        break;
                    case 2:
                        Response.Redirect(String.Format(@"CadastroEleicao.aspx?modo={0}&codigoEleicao={1}",
                        0, idEleicao));
                        break;
                    default:
                        break;
                }
        }

        private void ConfigurarModosDeTela()
        {
            int tipoUsuario = Convert.ToInt32(Session["tipoUser"]);

            switch (tipoUsuario)
            {
                case 6:
                    btNovaEleicao.Visible = false;
                    break;
                case 2:
                    btNovaEleicao.Visible = true;
                    break;
                default:
                    btNovaEleicao.Visible = false;
                    break;
            }
        }

        protected void btNovaVotacao_Click(object sender, EventArgs e)
        {
            IrParaPaginaDeCadastro();
        }

        private void IrParaPaginaDeCadastro()
        {
            Response.Redirect(String.Format(@"CadastroEleicao.aspx?modo=3")); //modo 3 significa apenas não ser 0 nem 1, portanto entrará como modo default do switch case: nova eleicao 
        }


        #region CodigoAntigo
        /*private void ListarEleicoesNaPagina()
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
        }*/
        #endregion

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            //object refUrl = ViewState["RefUrl"];
            //if (refUrl != null)
            

            switch (tipoUsuario)
            {
                case 2:
                    Response.Redirect("MenuInicialSindico.aspx");
                    break;
                case 6:
                    Response.Redirect("MenuInicialCondominoMorador.aspx");
                    break;
                default:
                    break;
            }
        }
    }
}