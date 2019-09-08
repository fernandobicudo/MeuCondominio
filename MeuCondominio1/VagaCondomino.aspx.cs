using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuCondominio1
{
    public partial class VagaCondomino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExibirVagasDoCondomino();
        }

        private void ExibirVagasDoCondomino()
        {
            Label1.Text =  Session["codigoUser"].ToString();
            Label2.Text =  Session["nomeUser"].ToString();
            Label3.Text =  Session["emailUser"].ToString();
            Label4.Text = Session["tipoUser"].ToString();
        }
    }
}