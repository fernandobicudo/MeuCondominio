using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuCondominio1
{
    public partial class MenuInicialCondomino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IrParaPaginaVagas(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("VagaCondomino.aspx"); 
        }

        protected void IrParaPaginaEleicoes(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ListaVotacaoEleicaoConsultaCondomino.aspx");
        }
    }
}