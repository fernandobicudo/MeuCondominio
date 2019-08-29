using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    class SorteioVagas
    {
        string tipoSorteio;
        DateTime dataSorteio;
        DateTime dataValidadeSorteioInicio;
        DateTime dataValidadeSorteioFim; //TODO: criar atributo no diagrama de classes
        bool associacaoVagasSequenciais; //TODO: atualizar nome da classe no diagrama de classes


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

        public void SortearVagas()
        {

        }

        public void AssociarVagasAUnidades()
        {

        }

        public void PublicarResultadoSorteio()
        {

        }


    }
    //TODO: criar métodos da classe SorteioVagas
}


