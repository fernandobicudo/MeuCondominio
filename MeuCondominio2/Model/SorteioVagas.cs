using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Unidade;
using MeuCondominio2.Services.VagaGaragem;
using MeuCondominio2.Services.ResultadoDoSorteio;
using MeuCondominio2.Services.SorteioVagas;

namespace MeuCondominio2.Model
{
    public class SorteioVagas
    {
        private int idSorteioVagas;
        private string tipoSorteio;
        private DateTime dataSorteio;
        private DateTime dataValidadeSorteioInicio;
        private DateTime dataValidadeSorteioFim; 
        private bool associacaoVagasSequenciais; 
        private int idCondominio;
        private int qtdeVagasPorUnidade; 

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

        public int GetIdSorteioVagas1()
        {
            return idSorteioVagas;
        }

        public void SetIdSorteioVagas1(int value)
        {
            idSorteioVagas = value;
        }

        public int GetIdSorteioVagas()
        {
            return idSorteioVagas;
        }

/*        public void SetIdSorteioVagas(int value)
        {
            idSorteioVagas = value;
        }*/


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
            //TODO: já há um método na view. Verificar como passar para cá.
        }


        public void SortearVagas(SorteioVagas sorteioVagas)
        {
            ResultadoSorteioPorUnidade resultadoPorUnidade;
            List<ResultadoSorteioPorUnidade> listaResultadoSorteio = new List<ResultadoSorteioPorUnidade>();
            ResultadoDoSorteio resultadoDoSorteio = new ResultadoDoSorteio();
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
                    resultadoPorUnidade = new ResultadoSorteioPorUnidade();
                    resultadoPorUnidade.SetIdUnidade(linha);
                    resultadoPorUnidade.SetIdSorteioVaga(idSorteioVagas);
                    resultadoPorUnidade.SetIdVagaDeGaragem(listaVagas[vagaSorteada]);
                    vagaSorteada++;
                    listaResultadoSorteio.Add(resultadoPorUnidade);
                }
            }

            //resultadoDoSorteio.SetResultadoSorteio(listaResultadoSorteio);

            GravaResultadoSorteio(listaResultadoSorteio);
        }

        public void SortearVagas(int idCondominio)
        {
            ResultadoSorteioPorUnidade resultadoPorUnidade;
            List<ResultadoSorteioPorUnidade> listaResultadoSorteio = new List<ResultadoSorteioPorUnidade>();
            ResultadoDoSorteio resultadoDoSorteio = new ResultadoDoSorteio();
            List<int> listaUnidades = CriaListaDeIDsDeUnidadesDoSorteio(idCondominio);
            List<int> listaVagas = CriarListaDeIDsDeVagasDeGaragem(idCondominio);
            List<int> listaUnidadesAleatorias = CriarListaAleatoriaDeInteiros(listaUnidades);
            
            int qtdVagas = listaVagas.Count;
            int vagaSorteada = 0;
            int idSorteioVagas = Convert.ToInt32(BuscarIddoSorteioDeVagasMaisRecenteDoCondominio(idCondominio).Rows[0]["idSorteioVagas"]);


            BuscaSorteioVagas buscaSorteioVagas = new BuscaSorteioVagas();
            int qtdVagasPorUnidade = buscaSorteioVagas.BuscarNumeroDeVagasPorUnidadeDoSorteio(idSorteioVagas);

            foreach (int linha in listaUnidadesAleatorias)
            {
                for (int i = 0; i < qtdVagasPorUnidade; i++)
                {
                    resultadoPorUnidade = new ResultadoSorteioPorUnidade();
                    resultadoPorUnidade.SetIdUnidade(linha);
                    resultadoPorUnidade.SetIdSorteioVaga(idSorteioVagas);
                    resultadoPorUnidade.SetIdVagaDeGaragem(listaVagas[vagaSorteada]);
                    vagaSorteada++;
                    listaResultadoSorteio.Add(resultadoPorUnidade);
                }
            }

            //resultadoDoSorteio.SetResultadoSorteio(listaResultadoSorteio);

            GravaResultadoSorteio(listaResultadoSorteio);
        }

        private void GravaResultadoSorteio(List<ResultadoSorteioPorUnidade> resultado)
        {
            GravaResultadoDoSorteio gravaResultadoDoSorteio = new GravaResultadoDoSorteio();
            gravaResultadoDoSorteio.GravarResultadoDoSorteio(resultado);
        }

        /*TODO: está gravando no banco de dados, mas,
        somente quando acionado pela segunda vez, a página do condômino exibe as vagas.*/

        /*TODO: Pegar número total de vagas, número total de unidades ocupadas, 
             *número de vagas por unidade, se são sequenciais.
             * Sortear as vagas por unidade conforme o número de vagas para cada
             * unidade. 
             * Se a vaga sorteada é sequencial de outra, ambas as vagas automaticamente serão associadas à unidade
             * PELO PERÍODO PREVISTO NO SORTEIO OU ATÉ A EXECUÇÃO DO SORTEIO SEGUINTE.
             * Daí é necessário retirar a vaga sequencial do sorteio para as unidades restantes.
             * Unidades desocupadas ficam por último no sorteio. *//*
        }*/

        private List<int> CriaListaDeIDsDeUnidadesDoSorteio(SorteioVagas sorteioVagas)
        {
            List<int> listaIDsDasUnidades = new List<int>();
            SelecionaUnidadesdoCondominio(sorteioVagas);

            foreach (DataRow linha in UnidadesDoCondominio.Rows)
            {
                listaIDsDasUnidades.Add(Convert.ToInt32(linha["idUnidade"]));
            }
            return listaIDsDasUnidades;
            //TODO: MASTER - depois de gerar a lista de inteiros, gerar a lista efetiva de IDs das unidades, relacionando a posição 
            //sorteada no vetor com o ID de fato.
        }

        private List<int> CriaListaDeIDsDeUnidadesDoSorteio(int idCondominio)
        {
            List<int> listaIDsDasUnidades = new List<int>();
            SelecionaUnidadesdoCondominio(idCondominio);

            foreach (DataRow linha in UnidadesDoCondominio.Rows)
            {
                listaIDsDasUnidades.Add(Convert.ToInt32(linha["idUnidade"]));
            }
            return listaIDsDasUnidades;
            //TODO: MASTER - depois de gerar a lista de inteiros, gerar a lista efetiva de IDs das unidades, relacionando a posição 
            //sorteada no vetor com o ID de fato.
        }

        private void SelecionaUnidadesdoCondominio(SorteioVagas sorteioVagas)
        {
            BuscaUnidade buscaUnidade = new BuscaUnidade();
            UnidadesDoCondominio = buscaUnidade.BuscarUnidadePorCondominio(sorteioVagas.GetIdCondominio());
        }

        private void SelecionaUnidadesdoCondominio(int idCondominio)
        {
            BuscaUnidade buscaUnidade = new BuscaUnidade();
            UnidadesDoCondominio = buscaUnidade.BuscarUnidadePorCondominio(idCondominio);
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
                    item = itemAleatorio.Next(1, lista.Count+1);

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
                listaVagas.Add(Convert.ToInt32(linha["idVagaGaragem"]));
            }
            return listaVagas;
        }

        private List<int> CriarListaDeIDsDeVagasDeGaragem(int idCondominio)
        {
            List<int> listaVagas = new List<int>();
            SelecionaVagasDoCondominio(idCondominio);

            foreach (DataRow linha in VagasDeGaragemDoCondominio.Rows)
            {
                listaVagas.Add(Convert.ToInt32(linha["idVagaGaragem"]));
            }
            return listaVagas;
        }

        private void SelecionaVagasDoCondominio(SorteioVagas sorteioVagas)
        {
            BuscaVagaGaragem buscaVagaGaragem = new BuscaVagaGaragem();
            VagasDeGaragemDoCondominio = buscaVagaGaragem.PesquisarVagasGaragemPorCondominio(sorteioVagas.GetIdCondominio());
        }

        private void SelecionaVagasDoCondominio(int idCondominio)
        {
            BuscaVagaGaragem buscaVagaGaragem = new BuscaVagaGaragem();
            VagasDeGaragemDoCondominio = buscaVagaGaragem.PesquisarVagasGaragemPorCondominio(idCondominio);
        }

        private DataTable BuscarIddoSorteioDeVagasMaisRecenteDoCondominio(int idCondominio)
        {
            BuscaSorteioVagas buscaSorteioVagas = new BuscaSorteioVagas();
            return buscaSorteioVagas.BuscarIdDoResultadoDoUltimoSorteioParaOCondominio(idCondominio);
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


