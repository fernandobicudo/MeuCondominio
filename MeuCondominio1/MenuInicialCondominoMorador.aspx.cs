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
        int tipoUsuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            tipoUsuario = Convert.ToInt32(Session["tipoUser"]);
        }

        protected void IrParaPaginaVagas(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("VagaCliente.aspx"); 
        }

        protected void IrParaPaginaEleicoes(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ConsultaListaEleicoes.aspx");
        }

        protected void IrParaPaginaMeuPerfil(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ClienteCadastro.aspx");
        }

        protected void IrParaPaginaReservas(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ClienteReservaEspacoLazer.aspx");
        }
    }
}