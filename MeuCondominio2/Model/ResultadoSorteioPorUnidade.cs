using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class ResultadoSorteioPorUnidade
    {
        private int idResultadoSorteio; //TODO: esta classe entra no diagrama de classe de negócio? 
        private int idUnidade;
        private int idVagaDeGaragem;
        private int idSorteioVaga;

        
        public ResultadoSorteioPorUnidade()
        {
        }

        public ResultadoSorteioPorUnidade(int idResultadoSorteio,
            int idUnidade,
            int idVagaDeGaragem,
            int idSorteioVaga)
        {
            this.idVagaDeGaragem = idVagaDeGaragem;
            this.idSorteioVaga = idSorteioVaga;
            this.idResultadoSorteio = idResultadoSorteio;
            this.idUnidade = idUnidade;
        }

        public ResultadoSorteioPorUnidade(int idUnidade, int idVagaDeGaragem, int idSorteioVaga)
        {
            this.idUnidade = idUnidade;
            this.idVagaDeGaragem = idVagaDeGaragem;
            this.idSorteioVaga = idSorteioVaga;
        }

        public int GetIdUnidade()
        {
            return idUnidade;
        }

        public void SetIdUnidade(int value)
        {
            idUnidade = value;
        }   

        public int GetIdVagaDeGaragem()
        {
            return idVagaDeGaragem;
        }

        public void SetIdVagaDeGaragem(int value)
        {
            idVagaDeGaragem = value;
        }

        public int GetIdResultadoSorteio()
        {
            return idResultadoSorteio;
        }

        public void SetIdResultadoSorteio(int value)
        {
            idResultadoSorteio = value;
        }

        public int GetIdSorteioVaga()
        {
            return idSorteioVaga;
        }

        public void SetIdSorteioVaga(int value)
        {
            idSorteioVaga = value;
        }

    }
}
