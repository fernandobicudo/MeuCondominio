using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services.ResultadoDoSorteio;


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
            DataTable dt;
            int idCondomino = Convert.ToInt32(Session["codigoUser"]);
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
           

            dt = BuscaResultadoDoSorteio.
                BuscarVagasDoResultadoPorIddoCondominoEIddoCondominio(idCondomino, idCondominio);

            /*Label dataSorteio = new Label();
            dataSorteio.Text = dt.Rows[0]["dataSorteio"].ToString();
            pnHeaderVaga.Controls.Add(dataSorteio);
*/            

            foreach (DataRow linha in dt.Rows) 
            {
                
                Label numVaga = new Label();
                numVaga.Attributes.Add("class", "teste");
                numVaga.Text = linha["numeracao"].ToString();
                pnNumeroVaga.Controls.Add(numVaga);

            }

  /*          Label dataValidade = new Label();
            dataValidade.Text = dt.Rows[0]["dataValidadeSorteioFim"].ToString();
*/

            /*            teste para exibir variáveis de sessão:
            */
            Label1.Text = Session["codigoUser"].ToString();
            Label2.Text = Session["nomeUser"].ToString();
            Label3.Text = Session["emailUser"].ToString();
            Label4.Text = Session["tipoUser"].ToString();
            Label5.Text = Session["codigoCondominio"].ToString();
        }


    }
}