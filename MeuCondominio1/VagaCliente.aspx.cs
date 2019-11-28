using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services.ResultadoDoSorteio;
using MeuCondominio2.Services.Ferramentas;


namespace MeuCondominio1
{
    public partial class VagaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExibirVagasDoCliente();
        }

        private void ExibirVagasDoCliente()
        {
            DataTable dt;
            int idCliente = Convert.ToInt32(Session["codigoUser"]);
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
            BuscaResultadoDoSorteio buscaResultadoDoSorteio = new BuscaResultadoDoSorteio();


            dt = buscaResultadoDoSorteio.
                BuscarVagasDoResultadoPorIdDoClienteEIddoCondominio(idCliente, idCondominio);
            Label tituloSorteio = new Label {
                CssClass = "label"
            };

            

            if (dt.Rows.Count > 0)
            {
                Formatadores formatadores = new Formatadores();
                tituloSorteio.Text = "Sorteio realizado em " + formatadores.FormatarDataParaExibicao(dt.Rows[0]["dataSorteio"].ToString());
                

                foreach (DataRow linha in dt.Rows)
                {
                    Label titulo = new Label
                    {
                        Text = "Vaga",
                        CssClass = "tituloVaga"
                    };

                    Label numVaga = new Label
                    {
                        CssClass = "numVaga",
                        Text = linha["numeracao"].ToString()
                    };

                    pnTituloNumeroVaga.Controls.Add(titulo);
                    pnNumeroVaga.Controls.Add(numVaga);
                }

                Label dataValidade = new Label();
                dataValidade.Text = "Validade: " + formatadores.FormatarDataParaExibicao(dt.Rows[0]["dataValidadeSorteioFim"].ToString());
                pnValidadeVaga.Controls.Add(dataValidade);
            }
            else
                tituloSorteio.Text = "Não há resultados de sorteios disponíveis no momento";

            pnHeaderVaga.Controls.Add(tituloSorteio);


            /*            teste para exibir variáveis de sessão:
            */
            /*            Label1.Text = Session["codigoUser"].ToString();
                        Label2.Text = Session["nomeUser"].ToString();
                        Label3.Text = Session["emailUser"].ToString();
                        Label4.Text = Session["tipoUser"].ToString();
                        Label5.Text = Session["codigoCondominio"].ToString();*/
        }

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            Response.Redirect("MenuInicialCondominoMorador.aspx");
        }
    }
}