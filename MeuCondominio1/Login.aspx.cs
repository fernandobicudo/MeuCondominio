using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services;
using System.Data;

namespace MeuCondominio1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["status"] == "invalido")
            {
                lbAviso.Text = "Dados inválidos";
            }

            if (Session["codigoUser"] != null)
            {
                lbCodUser.Text = lbCodUser.Text + (String)Session["codigoUser"].ToString();
                lbNomeUser.Text = lbNomeUser.Text + (String)Session["nomeUser"];
                lbEmailUser.Text = lbEmailUser.Text + (String)Session["emailUser"];
            }
        }

        protected void fazerLogin(object sender, EventArgs e)
        {
            DataTable dt;

            string email;
            string senha;

            email = txEmail.Text;
            senha = txSenha.Text;

            dt = BuscaLogin.buscaLogin(email);

            validaLogin(dt);

        }

        protected void validaLogin(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                Response.Redirect("Login.aspx?&status=invalido&p_email=invalido");
            }
            else if (String.Equals(dt.Rows[0]["senha"], txSenha.Text))
            {
                Session["codigoUser"] = dt.Rows[0]["id_usuario"];
                Session["nomeUser"] = dt.Rows[0]["nome"];
                Session["emailUser"] = dt.Rows[0]["email"];

                Response.Redirect("Login.aspx");

            }
            else
                Response.Redirect("Login.aspx?&status=invalido&p_email=invalido");
        }
    }

}
