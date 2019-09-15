using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;


namespace MeuCondominio1
{
    public partial class CadastroEleicao : System.Web.UI.Page
    {

        List<OpcaoDeVotacaoPlebiscito> listaOpcoesVotacaoPlebiscito= new List<OpcaoDeVotacaoPlebiscito>();
        OpcaoDeVotacaoPlebiscito opcaoDeVotacaoPlebiscito;
        OpcaoVotacao opcaoVotacao;
        TextBox txDescricaoPlebiscito;
        Button btAdicionarOpcaoDeVotacao;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdicionarOpcaoDeVotacao(object sender, ImageClickEventArgs e)
        {
            string tipoVotacao;

            tipoVotacao = ddTipoEleicao.SelectedValue;

            switch (tipoVotacao)
            {
                case "Plebiscito":
                    IncluirCamposDeCandidatoASindico();
                    break;
                case "Projetos e Serviços Prediais":
                    IncluirCamposDeServicoASerVotado();
                    break;
                case "Eleição para Síndico":
                    IncluirCamposDePlebiscito();
                    break;
                default:
                    AvisarParaEscolherOpcao(); //TODO: implementar validacao para AdicionarOpcaoDeVotacao somente depois de escolher um tipo de votação.
                    break;
            }
        }

       

        private void AvisarParaEscolherOpcao()
        {
            
        }

        private void IncluirCamposDePlebiscito()
        {
            int contador = 0;

            Label lbDescricaoPlebiscito = new Label
            {
                Text = "Opção de voto " + ++contador
            };
            
            txDescricaoPlebiscito = new TextBox();
            btAdicionarOpcaoDeVotacao = new Button {
                Text = "Adicionar"
                
            };
            btAdicionarOpcaoDeVotacao.Text = "Adicionar";
            btAdicionarOpcaoDeVotacao.Click += new EventHandler(this.BtIncluirOpcaoIndividualDeVotacaoPlebiscito_Click);
            pnInclusaoOpcaoaSerVotada.Controls.Add(lbDescricaoPlebiscito);
            pnInclusaoOpcaoaSerVotada.Controls.Add(txDescricaoPlebiscito);
            pnInclusaoOpcaoaSerVotada.Controls.Add(btAdicionarOpcaoDeVotacao);
            /*            TODO: incluir classe Plebiscito nos tipos de classe que hoje são "Candidato" (na verdade, a classe plebiscito 
                            conteria apenas os atributos da "Candidato"????
            */
        }


        private void IncluirOpcaoIndividualDeVotacaoPlebiscito()
        {
            opcaoDeVotacaoPlebiscito = new OpcaoDeVotacaoPlebiscito(txDescricaoPlebiscito.Text);
            listaOpcoesVotacaoPlebiscito.Add(opcaoDeVotacaoPlebiscito);
            gvOpcoesDeVotacaoAdicionadas.DataSource = listaOpcoesVotacaoPlebiscito;
            gvOpcoesDeVotacaoAdicionadas.DataBind();

        }


        private void IncluirCamposDeServicoASerVotado()
        {
            throw new NotImplementedException();
        }

        private void IncluirCamposDeCandidatoASindico()
        {
            throw new NotImplementedException();
        }

        void BtIncluirOpcaoIndividualDeVotacaoPlebiscito_Click(object sender, EventArgs e)
        {
            IncluirOpcaoIndividualDeVotacaoPlebiscito();
        }

        protected void CadastrarEleicao(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao(txNomeEleicao.Text,
                txDescricao.Text, ddTipoEleicao.SelectedValue.ToString(),
                "Nova", Convert.ToDateTime(txDataInicio.Text),
                Convert.ToDateTime(txDataFim.Text),
                Convert.ToInt32(Session["codigoCondominio"]));



            opcaoVotacao = new OpcaoVotacao(

        }
    }
}