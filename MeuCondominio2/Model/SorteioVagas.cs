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


        public List<ResultadoSorteio> SortearVagas(SorteioVagas sorteioVagas)
        {
            ResultadoSorteio resultadoPorUnidade;
            List<ResultadoSorteio> ListaResultadoSorteio = new List<ResultadoSorteio>();

            //            int qtdUnidadesDoCondominio, linhaUnidadeSorteada, vagaSorteada;
            int qtdVagasPorUnidade = sorteioVagas.GetQtdeVagasPorUnidade();
            int contador = 0;


            List<int> listaUnidades = new List<int>();
            listaUnidades = CriaListaDeUnidadesDoSorteio(sorteioVagas);

            List<int> listaVagas = new List<int>();
            listaVagas = CriaListaDeVagasDoSorteio(sorteioVagas);

            List<int> listaAleatoriaDeUnidades = new List<int>();

            listaAleatoriaDeUnidades = CriarListaAleatoriaDeInteiros(listaUnidades);

            foreach (int linha in listaAleatoriaDeUnidades)
            {

                for (int i = 0; i < qtdVagasPorUnidade; i++)
                {
                    resultadoPorUnidade = new ResultadoSorteio();
                    resultadoPorUnidade.SetLinhaArrayUnidade(listaUnidades[linha]);
                    resultadoPorUnidade.SetNumeracaoVagaDeGaragem(listaVagas[contador]);
                    ListaResultadoSorteio.Add(resultadoPorUnidade);
                }
                contador++;
            }

            foreach (ResultadoSorteio linha in ListaResultadoSorteio)
            {
                Console.WriteLine(linha.GetLinhaaArrayUnidade() + " - " + linha.GetNumeracaoVagaDeGaragem());

            }
            Console.ReadLine();

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

        private List<int> CriaListaDeUnidadesDoSorteio(SorteioVagas sorteioVagas)
        {
            List<int> listaUnidades = new List<int>();
            SelecionaUnidadesdoCondominio(sorteioVagas);

            foreach (DataRow linha in UnidadesDoCondominio.Rows)
            {
                listaUnidades.Add(Convert.ToInt32(linha["id"]));
            }
            return listaUnidades;
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
            }

            Console.OpenStandardOutput();
            //TODO: teste de saída em console: comentar quando estiver testado
            foreach (int linha in listaAleatoriaDeInteiros)
            {
                Console.WriteLine(linha);
            }
            Console.ReadLine();
            return listaAleatoriaDeInteiros;
        }

        private List<int> CriaListaDeVagasDoSorteio(SorteioVagas sorteioVagas)
        {
            List<int> listaVagas = new List<int>();
            SelecionaVagasDoCondominio(sorteioVagas);

            foreach (DataRow linha in VagasDeGaragemDoCondominio.Rows)
            {
                listaVagas.Add(Convert.ToInt32(linha["numeracao"]));
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


