using MeuCondominio2.Services.Eleicao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Eleicao.Voto;

namespace MeuCondominio1
{
    public partial class CondominoResultadoDaEleicao : System.Web.UI.Page
    {
        int idEleicao;

        protected void Page_Load(object sender, EventArgs e)
        {
            idEleicao = Convert.ToInt32(Request["codigoEleicao"]);
            lbTituloDaEleicao.Text = Request["tituloEleicao"];
            CarregaResultadosDaEleicao(idEleicao);
        }

        private void CarregaResultadosDaEleicao(int idEleicao)
        {
            gvResultadoDaEleicao.DataSource = BuscaVotos.BuscaQtdesDeVotosParaCadaOpcaoDaEleicao(idEleicao);
                
            gvResultadoDaEleicao.DataBind();
        }
        #region CodigoVelho
        /*        private DataTable BuscarOpcoesDeVotoDaEleicao(int idEleicao)
        {
            DataTable dt;
            dt = BuscaEleicao.BuscaOpcoesVotacao(Convert.ToInt32(Session["codigo"]));
            return dt;
            
        } */

        /*       MÉTODO INCORRETO, APONTANDO PARA ELE MESMO. NÃO ESTÁ CHAMANDO NINGUÉM.
 *        private DataTable BuscarOpcoesESuasQuantidadesDeVotosNaEleicao(int idEleicao)
        {
            DataTable dt;
            dt = BuscarOpcoesESuasQuantidadesDeVotosNaEleicao(idEleicao);
            return dt;
        }*/

        #endregion

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaListaEleicoes.aspx");
        }
    }
}