using System;
using System.Collections.Generic;
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



        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

            }

        }

        protected void AdicionarOpcaodeVotacao(object sender, EventArgs e)
        {
            blListaOpcoesAdicionadas.Items.Add(new ListItem(txOpcao.Text));
            txOpcao.Text = "";
        }


        
        public Eleicao ConstruirObjetoEleicao()
        {
            DateTime dataInicio, dataFim;

            dataInicio = Conversores.FormatarDataParaBancoDeDados(txDataInicio.Text);
            dataFim = Conversores.FormatarDataParaBancoDeDados(txDataFim.Text);

            Eleicao eleicao = new Eleicao(txNomeEleicao.Text,
                txDescricao.Text, ddTipoEleicao.SelectedValue.ToString(),
                true, dataInicio, dataFim,
                Convert.ToInt32(Session["codigoCondominio"]));

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