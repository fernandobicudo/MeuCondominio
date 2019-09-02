using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class ResultadoSorteio
    {
        private int LinhaArrayUnidade;
        private int NumeracaoVagaDeGaragem;

        public ResultadoSorteio()
        {
        }

        public ResultadoSorteio(int LinhaArrayUnidade, int numeracaoVagaDeGaragem)
        {
            this.LinhaArrayUnidade = LinhaArrayUnidade;
            this.NumeracaoVagaDeGaragem = numeracaoVagaDeGaragem;
        }

        public int GetLinhaaArrayUnidade()
        {
            return LinhaArrayUnidade;
        }

        public void SetLinhaArrayUnidade(int value)
        {
            LinhaArrayUnidade = value;
        }   

        public int GetNumeracaoVagaDeGaragem()
        {
            return NumeracaoVagaDeGaragem;
        }

        public void SetNumeracaoVagaDeGaragem(int value)
        {
            NumeracaoVagaDeGaragem = value;
        }
    }
}
