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

namespace MeuCondominio1
{
    public partial class cadastro_sorteio_vagas : System.Web.UI.Page
    {
        SorteioVagas sorteioVagas = new SorteioVagas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CadastrarSorteioDeVagas(object sender, EventArgs e)
        {
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);

            sorteioVagas = CriaObjetoSorteioVagas(idCondominio);
            /*            TODO: passar o idCondominio corretamente para o método  CriaObjetoSorteioVagas(1).
                        pensar se por session ou outro método.
            */
            GravaSorteioVagas.GravarSorteioVagas(sorteioVagas);
        }



        private SorteioVagas CriaObjetoSorteioVagas(int idCondominio)
        {
            SorteioVagas sorteio = new SorteioVagas();

            DateTime dataSorteio, dataValidadeInicio, dataValidadeFim;

            //URGENTE: ACERTAS FORMATO DE DATAS
            dataSorteio = Conversores.FormatarDataParaBancoDeDados(txDataSorteio.Text);
            dataValidadeInicio = Conversores.FormatarDataParaBancoDeDados(txDataValidadeInicio.Text); 
            dataValidadeFim = Conversores.FormatarDataParaBancoDeDados(txDataValidadeFim.Text); 

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


        private string ConverterDateTimeSQLite(string data) //TODO: verificar em qual framework deve ficar o método de conversão de data para o SQLite
        {
            DateTime dataConvertida;
            string dataString;

            dataConvertida = DateTime.ParseExact(data, "dd/mm/yyyy", null);

            dataString = dataConvertida.ToString("yyyy-mm-dd");

            return dataString;
        }

        protected void SortearVagas(object sender, EventArgs e)
        {
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);
            sorteioVagas.SortearVagas(idCondominio);
            
        }
       
        private SorteioVagas CriaObjetoSorteioVagas(DataTable dt)
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
        }

        private DataTable BuscarSorteioMaisRecente(int idCondominio)
        {
            return BuscaSorteioVagas.BuscarIdDoResultadoDoUltimoSorteioParaOCondominio(idCondominio);
        }

    }
}