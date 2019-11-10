using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;
using MeuCondominio2.Services.EspacoLazer;
using MeuCondominio2.Services.Unidade;
using System.Data;

namespace MeuCondominio1
{
    public partial class ClienteNovaReservaEspacoLazer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private ReservaEspacoLazer ConstruirObjetoReserva()
        {
            DateTime dataReserva;
            DataTable dt;
            int idUnidade, idCondominio, idUsuario, idEspacoLazer;
            Formatadores formatadores = new Formatadores();
            BuscaEspacoLazer buscaEspacoLazer = new BuscaEspacoLazer();
            BuscaUnidade buscaUnidade = new BuscaUnidade();

            EspacoLazer espacoLazer = new EspacoLazer();
            idUsuario = Convert.ToInt32(Session["codigoUser"]);
            idCondominio = Convert.ToInt32(Session["codigoCondominio"]);

            dt = buscaUnidade.BuscarUnidadePorCondominoDoCondominio(idUsuario, idCondominio);
            idUnidade = Convert.ToInt32(dt.Rows[0]["idUnidade"]);

            dt = buscaEspacoLazer.BuscarEspacoLazer(ddTipoDeEspaco.SelectedValue.ToString());

            idEspacoLazer = Convert.ToInt32(dt.Rows[0]["idEspacoLazer"]);

            dataReserva = formatadores.FormatarDataParaBancoDeDados(txDataReserva.Text);

            ReservaEspacoLazer reservaEspacoLazer = new ReservaEspacoLazer(dataReserva, idUnidade, idEspacoLazer);

            return reservaEspacoLazer;
        }

        private void GravarReserva()
        {
            GravaReservaEspacoLazer gravaReservaEspacoLazer = new GravaReservaEspacoLazer();
            gravaReservaEspacoLazer.GravarReservaEspacoLazer(ConstruirObjetoReserva());
        }

        protected void Bt_Reservar(object sender, EventArgs e)
        {
            GravarReserva();
        }
    }
}