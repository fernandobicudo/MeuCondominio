using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services.EspacoLazer;

namespace MeuCondominio1
{
    public partial class SindicoCadastroEspacoLazer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtCadastrarEspacoReserva(object sender, EventArgs e)
        {
            BtCadastrarEspacoReserva();
        }

        private void BtCadastrarEspacoReserva()
        {
            GravaEspacoLazer gravaEspacoLazer = new GravaEspacoLazer();
            gravaEspacoLazer.GravarEspacoLazer(ConstruirObjetoEspacoReserva());
        }

        private EspacoLazer ConstruirObjetoEspacoReserva()
        {
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
            EspacoLazer espacoLazer = new EspacoLazer(
                txNomeEspaco.Text,
                Convert.ToInt32(txAreaEspaco.Text),
                Convert.ToDouble(txValorReserva.Text),
                idCondominio);

            return espacoLazer;
        }
    }
}