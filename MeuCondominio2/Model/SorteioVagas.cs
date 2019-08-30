using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;

namespace MeuCondominio2.Model
{
    public class SorteioVagas
    {
        private string tipoSorteio;
        private DateTime dataSorteio;
        private DateTime dataValidadeSorteioInicio;
        private DateTime dataValidadeSorteioFim; //TODO: criar atributo no diagrama de classes
        private bool associacaoVagasSequenciais; //TODO: atualizar nome da classe no diagrama de classes


        public SorteioVagas()
        {

        }

        public SorteioVagas(string tipoSorteio,
            DateTime dataSorteio,
            DateTime dataValidadeSorteioInicio,
            DateTime dataValidadeSorteioFim,
            bool associacaoVagasSequenciais)
        {
            this.tipoSorteio = tipoSorteio;
            this.SetDataSorteio(dataSorteio);
            this.dataValidadeSorteioInicio = dataValidadeSorteioInicio;
            this.dataValidadeSorteioFim = dataValidadeSorteioFim;
            this.associacaoVagasSequenciais = associacaoVagasSequenciais;
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
        public void CadastrarSorteio()
        {

        }

        public void SortearVagas(Condominio condominio, )
        {
            
            Unidade unidade = new Unidade();
            VagaGaragem vagaGaragem = new VagaGaragem();


            int cod_condominio;
            int num_total_vagas;
            int num_total_unidades;

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


