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
    public partial class CadastroEleicao : System.Web.UI.Page
    {
        int ModoDeTela;
        int idEleicao;
        Eleicao eleicao;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

            }
            idEleicao = Convert.ToInt32(Request["codigoEleicao"]);
            ModoDeTela = Convert.ToInt32(Request["modo"]);
            ConfigurarModosDeTela();
        }

        protected void AdicionarOpcaodeVotacao(object sender, EventArgs e)
        {
            blListaOpcoesAdicionadas.Items.Add(new ListItem(txOpcao.Text));
            txOpcao.Text = "";
        }



        public Eleicao ConstruirObjetoEleicao()
        {
            DateTime dataInicio, dataFim;

            dataInicio = Formatadores.FormatarDataParaBancoDeDados(txDataInicio.Text);
            dataFim = Formatadores.FormatarDataParaBancoDeDados(txDataFim.Text);

            Eleicao eleicao = new Eleicao(txNomeEleicao.Text,
                txDescricao.Text, ddTipoEleicao.SelectedValue.ToString(),
                true, dataInicio, dataFim,
                Convert.ToInt32(Session["codigoCondominio"]));

            return eleicao;

        }

        public Eleicao ConstruirObjetoEleicao(DataTable dt)
        {
            eleicao = new Eleicao(
                Convert.ToInt32(dt.Rows[0]["idEleicao"]),
                dt.Rows[0]["nomeEleicao"].ToString(),
                dt.Rows[0]["descricaoEleicao"].ToString(),
                dt.Rows[0]["tipoEleicao"].ToString(),
                Convert.ToBoolean(dt.Rows[0]["statusEleicao"]),
                Convert.ToDateTime(dt.Rows[0]["dataInicioEleicao"]),
                Convert.ToDateTime(dt.Rows[0]["dataFimEleicao"]),
                Convert.ToInt32(dt.Rows[0]["idCondominio"]));

            return eleicao;
        }

        public List<string> opcoesVotacaoPlebiscito()
        {
            List<string> listaOpcoes = new List<string>();

            foreach (ListItem linha in blListaOpcoesAdicionadas.Items)
            {
                listaOpcoes.Add(linha.Value);
            }

            return listaOpcoes;
        }

        public void CadastrarEleicao()
        {
            Eleicao eleicao = ConstruirObjetoEleicao();
            GravaEleicao.GravaEleicaoDoCondominio(eleicao);

            GravaOpcoesVotacao.GravaOpcoesDeVotacaoDaEleicaoDePlebiscito(opcoesVotacaoPlebiscito());
        }


        protected void CadastrarEleicao_Click(object sender, EventArgs e)
        {
            CadastrarEleicao();
        }

        protected void RemoverOpcoes_Click(object sender, EventArgs e)
        {
            blListaOpcoesAdicionadas.Items.Clear();
        }

        protected void Encerrar_Eleicao_Click(object sender, EventArgs e)
        {
            AlteraEleicao.EncerrarEleicao(eleicao.GetIdEleicao());
        }

        private void ConfigurarModosDeTela()
        {
            switch (ModoDeTela)
            {
                case 0:
                    btCadastrar.Visible = false;
                    btEncerraEleicao.Visible = false;
                    btAdicionarOpcao.Visible = false;
                    btRemoverOpcoes.Visible = false;
                    CarregarCamposComDadosDaEleicao(ConstruirObjetoEleicao(BuscaEleicaoSelecionada(idEleicao)));
                    break;
                case 1:
                    btCadastrar.Visible = false;
                    btEncerraEleicao.Visible = true;
                    btAdicionarOpcao.Visible = false;
                    btRemoverOpcoes.Visible = false;
                    CarregarCamposComDadosDaEleicao(ConstruirObjetoEleicao(BuscaEleicaoSelecionada(idEleicao)));
                    break;
                default:
                    btCadastrar.Visible = true;
                    btEncerraEleicao.Visible = false;
                    btAdicionarOpcao.Visible = true;
                    btRemoverOpcoes.Visible = true;
                    break;
            }
        }

        private void CarregarCamposComDadosDaEleicao(Eleicao eleicao)
        {
            txNomeEleicao.Text = eleicao.GetNomeEleicao();
            txDescricao.Text = eleicao.GetDescricaoEleicao();
            txDataInicio.Text = Formatadores.FormatarDataParaExibicao(eleicao.GetDataInicioEleicao().ToString());
            txDataFim.Text = Formatadores.FormatarDataParaExibicao(eleicao.GetDataFimEleicao().ToString());
        }

        private DataTable BuscaEleicaoSelecionada(int idEleicao)
        {
            DataTable dt;
            dt = BuscaEleicao.BuscaEleicaoSelecionadaDoCondominio(idEleicao);

            return dt;
        }


        #region Codigos Velhos


        /*List<OpcaoDeVotacaoPlebiscito> listaOpcoesVotacaoPlebiscito = new List<OpcaoDeVotacaoPlebiscito>();*/
        /*OpcaoDeVotacaoPlebiscito opcaoDeVotacaoPlebiscito;*/
        /*TextBox txDescricaoPlebiscito;*/
        /*Button btAdicionarOpcaoDeVotacaoPlebiscito;
*/

        /*            opcaoDeVotacaoPlebiscito = new OpcaoDeVotacaoPlebiscito(Request["descricao"]);

                    if (opcaoDeVotacaoPlebiscito.GetDescricaoOpcaoIndividualDeVotacaoPlebiscito() != null)
                    {
                        listaOpcoesVotacaoPlebiscito.Add(opcaoDeVotacaoPlebiscito);
                        gvOpcoesDeVotacaoAdicionadas.DataSource = listaOpcoesVotacaoPlebiscito; //TODO: esta chamada está redundante em relação ao método
                        gvOpcoesDeVotacaoAdicionadas.DataBind();
                    }*/



        /*protected void AdicionarOpcaoDeVotacao(object sender, ImageClickEventArgs e)
        {
            string tipoVotacao;

            tipoVotacao = ddTipoEleicao.SelectedValue;

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
                    AvisarParaEscolherOpcao(); //TODO: implementar validacao para AdicionarOpcaoDeVotacao somente depois de escolher um tipo de votação.
                    break;
            }
        }
*/
        /*private void AvisarParaEscolherOpcao()
        {

        }*/

        /*private void IncluirCamposDePlebiscito()
        {
            int contador = 0;

            Label lbDescricaoPlebiscito = new Label
            {
                Text = "Opção de voto " + ++contador
            };

            txDescricaoPlebiscito = new TextBox();
            btAdicionarOpcaoDeVotacaoPlebiscito = new Button();
            btAdicionarOpcaoDeVotacaoPlebiscito.Text = "Adicionar";
            btAdicionarOpcaoDeVotacaoPlebiscito.Attributes.Add("runat", "server");
            btAdicionarOpcaoDeVotacaoPlebiscito.Click += new EventHandler(BtIncluirOpcaoIndividualDeVotacaoPlebiscito_Click);
            pnInclusaoOpcaoaSerVotada.Controls.Add(lbDescricaoPlebiscito);
            pnInclusaoOpcaoaSerVotada.Controls.Add(txDescricaoPlebiscito);
            pnInclusaoOpcaoaSerVotada.Controls.Add(btAdicionarOpcaoDeVotacaoPlebiscito);
            *//*            TODO: incluir classe Plebiscito nos tipos de classe que hoje são "Candidato" (na verdade, a classe plebiscito 
                            conteria apenas os atributos da "Candidato"????
            *//*
        }
*/

        /*private void IncluirOpcaoIndividualDeVotacaoPlebiscito()
        {
            opcaoDeVotacaoPlebiscito = new OpcaoDeVotacaoPlebiscito(txDescricaoPlebiscito.Text);
            listaOpcoesVotacaoPlebiscito.Add(opcaoDeVotacaoPlebiscito);
            gvOpcoesDeVotacaoAdicionadas.DataSource = listaOpcoesVotacaoPlebiscito;
            gvOpcoesDeVotacaoAdicionadas.DataBind();

        }
*/

        /*private void IncluirCamposDeServicoASerVotado()
        {
            throw new NotImplementedException();
        }
*/
        /*      private void IncluirCamposDeCandidatoASindico()
              {
                  throw new NotImplementedException();
              }
      */
        /* protected void BtIncluirOpcaoIndividualDeVotacaoPlebiscito_Click(object sender, EventArgs e)
         {
             IncluirOpcaoIndividualDeVotacaoPlebiscito();
         }
 */

        /*       protected void ibAdicionarOpcaoDeVotacao_Click(object sender, ImageClickEventArgs e)
               {

               }
       */
        /*        protected void IrParaCadastroOpcao(object sender, ImageClickEventArgs e)
                {
                    Response.Redirect("EleicaoAdicionarOpcaoParaVotacao.aspx");
                }
        */

        #endregion
    }
}