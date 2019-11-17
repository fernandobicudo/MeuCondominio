using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;
using MeuCondominio2.Services.EspacoLazer;
using System.Data;

namespace MeuCondominio1
{
    public partial class ClienteReservaEspacoLazer : System.Web.UI.Page
    {
        int idUsuario, idCondominio;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["RefUrl"] = Request.UrlReferrer.ToString();
            }

            idUsuario = Convert.ToInt32(Session["codigoUser"]);
            idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
            CarregarGridView();
        }

        protected void Bt_NovaReserva(object sender, EventArgs e)
        {
            Response.Redirect("ClienteNovaReservaEspacoLazer.aspx");
        }

        private DataTable ConsultarReservasDoCliente(int idUsuario, int idCondominio)
        {
            DataTable dt;
            BuscaReservaEspacoLazer buscaReservaEspacoLazer = new BuscaReservaEspacoLazer();

            dt = buscaReservaEspacoLazer.BuscarReservaEspacoLazer(idUsuario, idCondominio);

            return dt;
        }

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            object refUrl = ViewState["RefUrl"];
            if (refUrl != null)
                Response.Redirect((string)refUrl);
        }

        private void CarregarGridView()
        {
            if (ConsultarReservasDoCliente(idUsuario, idCondominio).Rows.Count > 0)
            {
                lbMensagemReserva.Visible = false;
                gvReservas.DataSource = ConsultarReservasDoCliente(idUsuario, idCondominio);
                gvReservas.DataBind();
            }
            else
            {
                gvReservas.Visible = false;
                lbMensagemReserva.Text = "Não há reservas para sua unidade até o momento.";
            }

        }
    }
}