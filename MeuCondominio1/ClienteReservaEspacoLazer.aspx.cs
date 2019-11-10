using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;

namespace MeuCondominio1
{
    public partial class ClienteReservaEspacoLazer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt_NovaReserva(object sender, EventArgs e)
        {
            Response.Redirect("ClienteNovaReservaEspacoLazer.aspx");
        }
    }
}