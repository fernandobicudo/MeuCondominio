using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuCondominio1
{
    public partial class SindicoSubMenuConfiguracoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IrParaPaginaCadastrarEspacoReserva(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SindicoCadastroEspacoLazer.aspx");
        }
    }
}