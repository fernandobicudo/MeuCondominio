using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuCondominio1
{
    public partial class MenuInicialSindico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IrParaPaginaSorteio(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CadastroSorteioVagas.aspx");
        }

        protected void IrParaPaginaEleicoes(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ConsultaListaEleicoes.aspx");
            /*Response.Redirect("CadastroEleicao.aspx");*/
        }

        protected void IrParaPaginaImportacaoDeCondominos(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SindicoImportarDadosDeCondominio.aspx");
        }
    }
}