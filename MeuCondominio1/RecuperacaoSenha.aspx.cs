using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data;
using MeuCondominio2.Services;

namespace MeuCondominio1
{
    public partial class RecuperacaoSenha : System.Web.UI.Page
    {
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            btVoltar.Visible = false;
        }

        private void enviarSenha()
        {

            if (emailCadastro() != "" && emailCadastro() != "naocadastrado" && txEmail.Text != "")
            {
                string senha = emailCadastro();
                MailAddress de = new MailAddress("fernandobicudo@gmail.com");
                MailAddress para = new MailAddress(txEmail.Text);
                MailMessage email = new MailMessage();
                email.Subject = "Recuperação de Senha";
                email.Body = String.Format(@"
<html>
<head>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
    <title>Recuperação de senha</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />


<body bgcolor=""#ffffff"" leftmargin=""0"" topmargin=""0"" marginwidth=""0"" marginheight=""0"" style=""margin: 0; padding: 0; background-color: #ffffff"">
    <center>
        <table width=""95%"" border=""0"" cellspacing=""0"" cellpadding=""0"" style=""max-width:700px;"">
            <tr>
                <td align=""center"" valign=""top"" bgcolor=""#01579B""> <font face=""Calibri, Tahoma, sans-serif"" size=""5"" color=""white"">Recuperação de senha<br /></font> </td>
            </tr>
            <tr>
                <td height=""20""> </td>
            </tr>
        </table>
        <table style=""margin:0 auto;"" width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
            <tr>
                <td align=""center"" valign=""top"" bgcolor=""white"">
                    <table width=""95%"" border=""0"" cellspacing=""0"" cellpadding=""0"" style=""max-width:700px;"">
                        <tr>
                            <td height=""30""> </td>
                        </tr>
                        <tr>
                            <td style=""padding:0 20px;"" width=""657"" align=""center"" valign=""top""> <font face=""Calibri, Tahoma, sans-serif"" size=""4"" color=""#01579B"" text-decoration=""none""><b>Seu usuário:</b> {0}<br><b>Sua senha:</b> {1}</font> </td>
                        </tr>
                        <tr>
                            <td height=""30""> </td>
                        </tr>
                        <tr>
                    </table>
                </td>
            <tr>
                <td height=""25""> </td>
            </tr>
        </table>
    </center>
</body>
</html>", txEmail.Text, emailCadastro());
                email.IsBodyHtml = true; //para aceitar tags html
                email.From = de;
                email.To.Add(para);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                try
                {
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("fernandobicudo@gmail.com", "4s4rm4s30s84r03s4ss1n4l4d0s");
                    smtp.Send(email);
                    lbResultado.Text = "Email enviado com sucesso!";

                }
                catch (Exception error)
                {
                    lbResultado.Text = "Ocorreu um erro no envio: " + error.Message;
                }
            }
        }

        private string emailCadastro()
        {
            string senha;


            dt = BuscaLogin.PesquisarLogin(txEmail.Text);

            if (dt.Rows.Count != 0)
                senha = (string)dt.Rows[0]["senha"];
            else
            {
                lbResultado.Text = "E-mail não cadastrado.";
                btEnviar.Visible = false;
                btVoltar.Visible = true;
                senha = "naocadastrado";
            }
            return senha;
        }


        protected void btReenviarSenha(object sender, EventArgs e)
        {
            enviarSenha();
            btEnviar.Visible = false;
            btVoltar.Visible = true;
        }

        protected void btVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}