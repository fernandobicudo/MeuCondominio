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
        private int idSorteioVagas;
        private string tipoSorteio;
        private DateTime dataSorteio;
        private DateTime dataValidadeSorteioInicio;
        private DateTime dataValidadeSorteioFim; //TODO: criar atributo no diagrama de classes SorteioVagas
        private bool associacaoVagasSequenciais; //TODO: atualizar nome da classe no diagrama de classes
        private int idCondominio;
        private int qtdeVagasPorUnidade; //TODO: criar atributo no diagrama de classes SorteioVagas

        private DataTable UnidadesDoCondominio;
        private DataTable VagasDeGaragemDoCondominio;

        public int GetIdSorteioVagas()
        {
            return idSorteioVagas;
        }

        public void SetIdSorteioVagas(int value)
        {
            idSorteioVagas = value;
        }


        #region Construtores
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

        public SorteioVagas(int idSorteioVagas,
            string tipoSorteio,
            DateTime dataSorteio,
            DateTime dataValidadeSorteioInicio,
            DateTime dataValidadeSorteioFim,
            bool associacaoVagasSequenciais,
            int idCondominio,
            int qtdeVagasPorUnidade)
        {
            this.idSorteioVagas = idSorteioVagas;
            this.tipoSorteio = tipoSorteio;
            this.SetDataSorteio(dataSorteio);
            this.dataValidadeSorteioInicio = dataValidadeSorteioInicio;
            this.dataValidadeSorteioFim = dataValidadeSorteioFim;
            this.associacaoVagasSequenciais = associacaoVagasSequenciais;
            this.idCondominio = idCondominio;
            this.qtdeVagasPorUnidade = qtdeVagasPorUnidade;
        }


        #endregion

        #region Getters e Setters
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

        #endregion

        public void CadastrarSorteio()
        {

        }


        public List<ResultadoSorteio> SortearVagas2(SorteioVagas sorteioVagas)
        {
            ResultadoSorteio resultadoPorUnidade; 
            List<ResultadoSorteio> resultadoSorteio = new List<ResultadoSorteio>();
            List<int> listaUnidades = CriaListaDeIDsDeUnidadesDoSorteio(sorteioVagas);
            List<int> listaVagas = CriarListaDeIDsDeVagasDeGaragem(sorteioVagas);
            List<int> listaUnidadesAleatorias = CriarListaAleatoriaDeInteiros(listaUnidades);
            int qtdVagasPorUnidade = sorteioVagas.GetQtdeVagasPorUnidade();
            int qtdVagas = listaVagas.Count;
            int vagaSorteada = 0;
            int idSorteioVagas = sorteioVagas.GetIdSorteioVagas();
                            

            foreach (int linha in listaUnidadesAleatorias)
            {
                for (int i = 0; i < qtdVagasPorUnidade; i++)
                {
                    resultadoPorUnidade = new ResultadoSorteio();
                    resultadoPorUnidade.SetIdUnidade(linha);
                    resultadoPorUnidade.SetIdSorteioVaga(idSorteioVagas);
                    resultadoPorUnidade.SetIdVagaDeGaragem(listaVagas[vagaSorteada]);
                    vagaSorteada++;
                    resultadoSorteio.Add(resultadoPorUnidade);
                }
            }
            return resultadoSorteio;

        }

        public List<ResultadoSorteio> SortearVagas(SorteioVagas sorteioVagas)
        {
            ResultadoSorteio resultadoPorUnidade;
            List<ResultadoSorteio> ListaResultadoSorteio = new List<ResultadoSorteio>();

            //            int qtdUnidadesDoCondominio, linhaUnidadeSorteada, vagaSorteada;
            int qtdVagasPorUnidade = sorteioVagas.GetQtdeVagasPorUnidade();
            int contador = 0;


            List<int> listaUnidades = new List<int>();
            listaUnidades = CriaListaDeIDsDeUnidadesDoSorteio(sorteioVagas);

            List<int> listaVagas = new List<int>();
            listaVagas = CriarListaDeIDsDeVagasDeGaragem(sorteioVagas);

            List<int> listaAleatoriaDeUnidades = new List<int>();

            listaAleatoriaDeUnidades = CriarListaAleatoriaDeInteiros(listaUnidades);

            foreach (int linha in listaAleatoriaDeUnidades)
            {

                for (int i = 0; i < qtdVagasPorUnidade; i++)
                {
                    resultadoPorUnidade = new ResultadoSorteio();
                    resultadoPorUnidade.SetIdUnidade(listaUnidades[linha]);
                    resultadoPorUnidade.SetIdVagaDeGaragem(listaVagas[contador]);
                    resultadoPorUnidade.SetIdSorteioVaga(sorteioVagas.GetIdSorteioVagas());
                    ListaResultadoSorteio.Add(resultadoPorUnidade);
                }
                contador++;
            }


            return ListaResultadoSorteio;

            /*Pegar número total de vagas, número total de unidades ocupadas, 
             *número de vagas por unidade, se são sequenciais.
             * Sortear as vagas por unidade conforme o número de vagas para cada
             * unidade. 
             * Se a vaga sorteada é sequencial de outra, ambas as vagas automaticamente serão associadas à unidade
             * PELO PERÍODO PREVISTO NO SORTEIO OU ATÉ A EXECUÇÃO DO SORTEIO SEGUINTE.
             * Daí é necessário retirar a vaga sequencial do sorteio para as unidades restantes.
             * Unidades desocupadas ficam por último no sorteio. */
        }

        private List<int> CriaListaDeIDsDeUnidadesDoSorteio(SorteioVagas sorteioVagas)
        {
            List<int> listaIDsDasUnidades = new List<int>();
            SelecionaUnidadesdoCondominio(sorteioVagas);

            foreach (DataRow linha in UnidadesDoCondominio.Rows)
            {
                listaIDsDasUnidades.Add(Convert.ToInt32(linha["id"]));
            }
            return listaIDsDasUnidades;
        }

        private void SelecionaUnidadesdoCondominio(SorteioVagas sorteioVagas)
        {
            UnidadesDoCondominio = BuscaUnidade.PesquisarUnidadePorCondominio(sorteioVagas.GetIdCondominio());
        }

        private List<int> CriarListaAleatoriaDeInteiros(List<int> lista)
        {
            List<int> listaAleatoriaDeInteiros = new List<int>();
            int item;
            Random itemAleatorio = new Random();

            foreach (int linha in lista)
            {
                do
                {
                    item = itemAleatorio.Next(0, lista.Count);

                } while (listaAleatoriaDeInteiros.Contains(item));
                listaAleatoriaDeInteiros.Add(item);
                //TODO: dar mais agilidade ao algoritmo do sorteio, desconsiderando os números já sorteados. 
            }
            return listaAleatoriaDeInteiros;
        }

        private List<int> CriarListaDeIDsDeVagasDeGaragem(SorteioVagas sorteioVagas)
        {
            List<int> listaVagas = new List<int>();
            SelecionaVagasDoCondominio(sorteioVagas);

            foreach (DataRow linha in VagasDeGaragemDoCondominio.Rows)
            {
                listaVagas.Add(Convert.ToInt32(linha["id"]));
            }
            return listaVagas;
        }

        private void SelecionaVagasDoCondominio(SorteioVagas sorteioVagas)
        {
            VagasDeGaragemDoCondominio = BuscaVagaGaragem.PesquisarVagasGaragemPorCondominio(sorteioVagas.GetIdCondominio());
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


