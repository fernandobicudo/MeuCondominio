using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuCondominio1
{
    public partial class CadastroEleicao : System.Web.UI.Page
    {
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
                    AvisarParaEscolherOpcao();
                    break;
            }
        }

        private void IncluirCamposDeServicoASerVotado()
        {
            throw new NotImplementedException();
        }

        private void IncluirCamposDeCandidatoASindico()
        {
            throw new NotImplementedException();
        }

        private void AvisarParaEscolherOpcao()
        {
            throw new NotImplementedException();
        }

        private void IncluirCamposDePlebiscito()
        {
            Label lbDescricaoPlebiscito = new Label();
            TextBox txDescricaoPlebiscito = new TextBox();
            Button btAdicionarOpcaoDeVotacao = new Button();
            {
                

            };



            pnInclusaoOpcaoaSerVotada.Controls.Add(lbDescricaoPlebiscito);
            pnInclusaoOpcaoaSerVotada.Controls.Add(txDescricaoPlebiscito);
            pnInclusaoOpcaoaSerVotada.Controls.Add(btAdicionarOpcaoDeVotacao);
            /*            TODO: incluir classe Plebiscito nos tipos de classe que hoje são "Candidato" (na verdade, a classe plebiscito 
                            conteria apenas os atributos da "Candidato"????
            */
        }


        private string IncluirOpcaoDeVotacaoPlebiscito()
        {
            throw new NotImplementedException();
        }


        private void IncluirCamposDeServicoASerVotado()
        {
            throw new NotImplementedException();
        }

        private void IncluirCamposDeCandidatoASindico()
        {
            throw new NotImplementedException();
        }
    }
}