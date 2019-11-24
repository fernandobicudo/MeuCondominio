using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MeuCondominio1
{
    public partial class AlteracaoDeSenha : System.Web.UI.Page
    {
        string origem;

        protected void Page_Load(object sender, EventArgs e)
        {
            origem = Request["origem"];

            if (!IsPostBack)
            {
                ViewState["RefUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void Bt_AlterarSenha(object sender, EventArgs e)
        {

        }

        private void AlterarSenha()
        {
            switch (origem)
            {
                case "logado":
                    int idUsuario = Convert.ToInt32(Session["codigoUsuario"]);

                    break;

            }
        }

        private void AlterarModoDaPagina()
        {
            

            switch (origem)
            {
                case "logado":
                    txEmail.Visible = false;
                    lbEmail.Visible = false;
                    btVerificar.Visible = false;
                    break;
                case "email":
                    txEmail.Visible = true;
                    txEmail.Enabled = false;
                    lbEmail.Visible = true;
                    btVerificar.Visible = false;
                    break;
                default:
                    txEmail.Visible = true;
                    txEmail.Enabled = true;
                    lbEmail.Visible = true;
                    btVerificar.Visible = true;
                    break;
            }
        }

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            //object refUrl = ViewState["RefUrl"];
            //if (refUrl != null)
                Response.Redirect("MenuInicialCondominoMorador.aspx");

        }
    }
}