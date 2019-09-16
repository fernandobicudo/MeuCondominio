using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class Unidade
    {
        private int idUnidade;
        private int qtdVagas;
        private string identificacao;
        private bool statusInadimplencia; 
        private bool statusOcupacao;

        public Unidade()
        {
        }

        public Unidade(int idUnidade, int qtdVagas, string identificacao, bool statusInadimplencia, bool statusOcupacao)
        {
            this.idUnidade = idUnidade;
            this.qtdVagas = qtdVagas;
            this.identificacao = identificacao;
            this.statusInadimplencia = statusInadimplencia;
            this.statusOcupacao = statusOcupacao;
        }

        public int IdUnidade { get => idUnidade; set => idUnidade = value; }
        public int QtdVagas { get => qtdVagas; set => qtdVagas = value; }
        public string Identificacao { get => identificacao; set => identificacao = value; }
        public bool StatusInadimplencia { get => statusInadimplencia; set => statusInadimplencia = value; }
        public bool StatusOcupacao { get => statusOcupacao; set => statusOcupacao = value; }
    }
    //TODO: criar métodos da classe Unidade
}
