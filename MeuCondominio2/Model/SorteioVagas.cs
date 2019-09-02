using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Unidade;
using MeuCondominio2.Services.VagaGaragem;

namespace MeuCondominio2.Model
{
    public class SorteioVagas
    {
        private string tipoSorteio;
        private DateTime dataSorteio;
        private DateTime dataValidadeSorteioInicio;
        private DateTime dataValidadeSorteioFim; //TODO: criar atributo no diagrama de classes SorteioVagas
        private bool associacaoVagasSequenciais; //TODO: atualizar nome da classe no diagrama de classes
        private int idCondominio;
        private int qtdeVagasPorUnidade; //TODO: criar atributo no diagrama de classes SorteioVagas

        private DataTable UnidadesDoCondominio;
        private DataTable VagasDeGaragemDoCondominio;




        public SorteioVagas()
        {

        }

        public SorteioVagas(string tipoSorteio,
            DateTime dataSorteio,
            DateTime dataValidadeSorteioInicio,
            DateTime dataValidadeSorteioFim,
            bool associacaoVagasSequenciais,
            int idCondominio,
            int qtdeVagasPorUnidade)
        {
            this.tipoSorteio = tipoSorteio;
            this.SetDataSorteio(dataSorteio);
            this.dataValidadeSorteioInicio = dataValidadeSorteioInicio;
            this.dataValidadeSorteioFim = dataValidadeSorteioFim;
            this.associacaoVagasSequenciais = associacaoVagasSequenciais;
            this.idCondominio = idCondominio;
            this.qtdeVagasPorUnidade = qtdeVagasPorUnidade;
        }

        public string GetTipoSorteio()
        {
            return tipoSorteio;
        }

        public void SetTipoSorteio(string value)
        {
            tipoSorteio = value;
        }


        public DateTime GetDataValidadeSorteioInicio()
        {
            return dataValidadeSorteioInicio;
        }

        public void SetDataValidadeSorteioInicio(DateTime value)
        {
            dataValidadeSorteioInicio = value;
        }

        public DateTime GetDataValidadeSorteioFim()
        {
            return dataValidadeSorteioFim;
        }

        public void SetDataValidadeSorteioFim(DateTime value)
        {
            dataValidadeSorteioFim = value;
        }

        public bool GetAssociacaoVagasSequenciais()
        {
            return associacaoVagasSequenciais;
        }

        public void SetAssociacaoVagasSequenciais(bool value)
        {
            associacaoVagasSequenciais = value;
        }

        public DateTime GetDataSorteio()
        {
            return dataSorteio;
        }


        public void SetDataSorteio(DateTime value)
        {
            dataSorteio = value;
        }

        public int GetIdCondominio()
        {
            return idCondominio;
        }

        public void SetIdCondominio(int value)
        {
            idCondominio = value;
        }

        public int GetQtdeVagasPorUnidade()
        {
            return qtdeVagasPorUnidade;
        }

        public void SetQtdeVagasPorUnidade(int value)
        {
            qtdeVagasPorUnidade = value;
        }

        public void CadastrarSorteio()
        {

        }

        public void SortearVagas(SorteioVagas sorteioVagas)
        {
            int contadorUnidades, linhaUnidadeSorteada, vagaSorteada;
            int qtdVagasPorUnidade = sorteioVagas.GetQtdeVagasPorUnidade();

            Random sortearNumeracaoVaga = new Random();
            Random sortearLinhaArrayUnidade = new Random();

            List<int> listaUnidades = new List<int>();
            List<int> listaVagas = new List<int>();

            ResultadoSorteio resultado;
            List<ResultadoSorteio> ListaResultadoSorteio = new List<ResultadoSorteio>();


            UnidadesDoCondominio = BuscaUnidade.PesquisarUnidadePorCondominio(sorteioVagas.GetIdCondominio());
            VagasDeGaragemDoCondominio = BuscaVagaGaragem.PesquisarVagaGaragem(sorteioVagas.GetIdCondominio());

            contadorUnidades = UnidadesDoCondominio.Rows.Count;

            foreach (DataRow linha in UnidadesDoCondominio.Rows)
            {
                listaUnidades.Add(Convert.ToInt32(linha["id"]));
            }

            foreach (DataRow linha in VagasDeGaragemDoCondominio.Rows)
            {
                listaVagas.Add(Convert.ToInt32(linha["id"]));
            }

            for (int j = 0; j < (listaUnidades.Count-1)*qtdeVagasPorUnidade; j++)
            {
                resultado = new ResultadoSorteio();
                do
                {
                    linhaUnidadeSorteada = sortearLinhaArrayUnidade.Next(0, listaUnidades.Count-1);
                    vagaSorteada = sortearNumeracaoVaga.Next(1, listaVagas.Count);
                    resultado.SetLinhaArrayUnidade(linhaUnidadeSorteada);
                    resultado.SetNumeracaoVagaDeGaragem(vagaSorteada);
                    
                } while (ListaResultadoSorteio.Contains(resultado));

                for (int i = 0; i < qtdVagasPorUnidade; i++)
                {
                    ListaResultadoSorteio.Add(resultado);

                    if (vagaSorteada%2==0)
                    {
                        resultado = new ResultadoSorteio();
                        //TODO: CONTINUAR A PARTIR DAQUI
                    }
                }
            }










            /*Pegar número total de vagas, número total de unidades ocupadas, 
             *número de vagas por unidade, se são sequenciais.
             * Sortear as vagas por unidade conforme o número de vagas para cada
             * unidade. 
             * Se a vaga sorteada é sequencial de outra, ambas as vagas automaticamente serão associadas à unidade
             * PELO PERÍODO PREVISTO NO SORTEIO OU ATÉ A EXECUÇÃO DO SORTEIO SEGUINTE.
             * Daí é necessário retirar a vaga sequencial do sorteio para as unidades restantes.
             * Unidades desocupadas ficam por último no sorteio. */
        }


        public void AssociarVagasAUnidades()
        {
            /*TODO: será necessário persistir a associação em banco de dados, por Condominio e por Sorteio.
            O último sorteio é o que conta. */
        }

        public void PublicarResultadoSorteio()
        {
            //TODO: este método provavelmente pertence à View, e não ao model. É método de exibição. 
        }



    }
    //TODO: criar métodos da classe SorteioVagas
}


