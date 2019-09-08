using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;
using MeuCondominio2.Services;
using MeuCondominio2.Services.SorteioVagas;
using System.Runtime.InteropServices;

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
            sorteioVagas = CriaObjetoSorteioVagas(2);
            /*            TODO: passar o idCondominio corretamente para o método  CriaObjetoSorteioVagas(1).
                        pensar se por session ou outro método.
            */
            GravaSorteioVagas.GravarSorteioVagas(sorteioVagas);
        }

        private SorteioVagas CriaObjetoSorteioVagas(int idCondominio)
        {
            SorteioVagas sorteio = new SorteioVagas();

            DateTime dataSorteio, dataValidadeInicio, dataValidadeFim;

            dataSorteio = DateTime.ParseExact(txDataSorteio.Text, "MM/dd/yyyy", null);
            dataValidadeInicio = DateTime.ParseExact(txDataValidadeInicio.Text, "MM/dd/yyyy", null);
            dataValidadeFim = DateTime.ParseExact(txDataValidadeFim.Text, "MM/dd/yyyy", null);

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
            sorteioVagas.SortearVagas(CriaObjetoSorteioVagas(1)); //TODO: usando id 1 de COndominio. Tornar dinâmico, pegando variavel de sessão.
        }
    }
}