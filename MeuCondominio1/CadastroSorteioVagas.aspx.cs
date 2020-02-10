using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services;
using MeuCondominio2.Services.SorteioVagas;
using MeuCondominio2.Services.ResultadoDoSorteio;
using MeuCondominio2.Services.Ferramentas;
using System.Runtime.InteropServices;
using System.Data;
/*TODO: aplicar bootstrap */
namespace MeuCondominio1
{
    public partial class CadastroSorteioVagas : System.Web.UI.Page
    {
        SorteioVagas sorteioVagas = new SorteioVagas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["RefUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void CadastrarSorteioDeVagas(object sender, EventArgs e)
        {
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);

            sorteioVagas = CriaObjetoSorteioVagas(idCondominio);
            /*            TODO: passar o idCondominio corretamente para o método  CriaObjetoSorteioVagas(1).
                        pensar se por session ou outro método.
            */
            GravaSorteioVagas gravaSorteioVagas = new GravaSorteioVagas();
            gravaSorteioVagas.GravarSorteioVagas(sorteioVagas);

            Response.Write("<script>alert('Concluído com sucesso!')</script>");
        }



        private SorteioVagas CriaObjetoSorteioVagas(int idCondominio)
        {
            SorteioVagas sorteio = new SorteioVagas();

            DateTime dataSorteio, dataValidadeInicio, dataValidadeFim;

            Formatadores formatadores = new Formatadores();
            dataSorteio = formatadores.FormatarDataParaBancoDeDados(txDataSorteio.Text);
            dataValidadeInicio = formatadores.FormatarDataParaBancoDeDados(txDataValidadeInicio.Text); 
            dataValidadeFim = formatadores.FormatarDataParaBancoDeDados(txDataValidadeFim.Text); 

            if (rbSeHaVagasSequenciaisSim.Checked == true)
                sorteio.SetAssociacaoVagasSequenciais(true);
            else if (rbSeHaVagasSequenciaisSim.Checked == false)
                sorteio.SetAssociacaoVagasSequenciais(false);

            sorteio.SetDataSorteio(dataSorteio);

            sorteio.SetDataValidadeSorteioInicio(dataValidadeInicio);

            sorteio.SetDataValidadeSorteioFim(dataValidadeFim);

            if (rbFiladeSorteio.Checked == true)
                sorteio.SetTipoSorteio("Fila");
            else if (rbSorteioPorUnidade.Checked == true)
                sorteio.SetTipoSorteio("Sorteio por unidade");

            sorteio.SetIdCondominio(idCondominio);

            int qtdVagasPorUnidade;

            qtdVagasPorUnidade = Convert.ToInt32(ddVagasPorUnidade.SelectedItem.Value);

            sorteio.SetQtdeVagasPorUnidade(qtdVagasPorUnidade);

            return sorteio;
        }


        protected void SortearVagas(object sender, EventArgs e)
        {
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
            sorteioVagas.SortearVagas(idCondominio);
            
        }

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            object refUrl = ViewState["RefUrl"];
            if (refUrl != null)
                Response.Redirect("MenuInicialSindico.aspx");

        }

        /*        private SorteioVagas CriaObjetoSorteioVagas(DataTable dt)
                {
                    SorteioVagas sorteioVagas = new SorteioVagas(
                        Convert.ToInt32(dt.Rows[0]["id"]),
                        dt.Rows[0]["tipoSorteio"].ToString(),
                        Convert.ToDateTime(dt.Rows[0]["dataSorteio"]),
                        Convert.ToDateTime(dt.Rows[0]["dataValidadeSorteioInicio"]),
                        Convert.ToDateTime(dt.Rows[0]["dataValidadeSorteioFim"]),
                        Convert.ToBoolean(dt.Rows[0]["associarVagasSequenciais"]),
                        Convert.ToInt32(dt.Rows[0]["qtdeVagasPorUnidade"]),
                        Convert.ToInt32(dt.Rows[0]["idCondominio"]));

                    return sorteioVagas;
                }*/

        /*        private DataTable BuscarSorteioMaisRecente(int idCondominio)
                {
                    return BuscaSorteioVagas.BuscarIdDoResultadoDoUltimoSorteioParaOCondominio(idCondominio);
                }
        */
    }
}