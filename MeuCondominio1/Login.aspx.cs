using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services;
using MeuCondominio2.Services.Sindico;
using MeuCondominio2.Services.Condominio;
using System.Data;

namespace MeuCondominio1
{
    public partial class Login : System.Web.UI.Page
    {
        string email;
        string senha;

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


            email = txEmail.Text;
            senha = Criptografia.Encriptar(txSenha.Text);

            dt = BuscaLogin.PesquisarLogin(email);

            validaLogin(dt);
        }

        protected void validaLogin(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                Response.Redirect("Login.aspx?&status=invalido&p_email=invalido");
            }
            else if (String.Equals(dt.Rows[0]["senha"], senha))
            {
                Session["codigoUser"] = dt.Rows[0]["id_usuario"];
                Session["nomeUser"] = dt.Rows[0]["nome"];
                Session["emailUser"] = dt.Rows[0]["email"];
                Session["tipoUser"] = dt.Rows[0]["tipo_usuario"];

                int tipoUsuario = Convert.ToInt32(dt.Rows[0]["tipo_usuario"]);
                int codigoUsuario = Convert.ToInt32(Session["codigoUser"]);

                switch (tipoUsuario) {
                    case 1:
                        PreencherVariaveisDeSessaoCondomino(codigoUsuario);
                        /*                        Response.Redirect("VagaCondomino.aspx"); //TODO: após testado, trocar para MenuInicialCondomino acima.*/
                        Response.Redirect("MenuInicialCondomino.aspx");
                        break;
                    case 2:
                        PreencheVariaveisDeSessaoSindico(codigoUsuario);
                        Response.Redirect("MenuInicialSindico.aspx"); //TODO: linkar para menu do administrador.
                        break;
                    default:
                        Response.Redirect("MenuInicialCondomino.aspx"); //TODO: como tratar o default do switch case?
                        break;
                }
            }
            else
                Response.Redirect("Login.aspx?&status=invalido&p_email=invalido");
        }

        private void PreencheVariaveisDeSessaoSindico(int idSindico)
        {
            DataTable dt;
            dt = BuscaSindico.PesquisarSindico(idSindico);
            Session["codigoCondominio"] = dt.Rows[0]["idCondominio"];
        }

        private void PreencherVariaveisDeSessaoCondomino(int idCondomino)
        {
            DataTable dt;
            dt = BuscaCondominio.BuscarCondominioPorIddoCondomino(idCondomino);

            Session["codigoCondominio"] = dt.Rows[0]["idCondominio"];
        }
    }
}
