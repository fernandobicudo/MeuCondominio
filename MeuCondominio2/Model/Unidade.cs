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
        private int idCondominio;
        private int idCliente;

        

        public Unidade()
        {

        }

        public Unidade(int idUnidade,
            int qtdVagas,
            string identificacao,
            bool statusInadimplencia,
            bool statusOcupacao,
            int idCondominio,
            int idCliente)
        {
            this.idUnidade = idUnidade;
            this.qtdVagas = qtdVagas;
            this.identificacao = identificacao;
            this.statusInadimplencia = statusInadimplencia;
            this.statusOcupacao = statusOcupacao;
            this.idCondominio = idCondominio;
            this.idCliente = idCliente;
        }

        public Unidade(int qtdVagas,
            string identificacao,
            bool statusInadimplencia,
            bool statusOcupacao,
            int idCondominio,
            int idCliente)
        {
            this.qtdVagas = qtdVagas;
            this.identificacao = identificacao;
            this.statusInadimplencia = statusInadimplencia;
            this.statusOcupacao = statusOcupacao;
            this.idCondominio = idCondominio;
            this.idCliente = idCliente;
        }

        public int GetIdUnidade()
        {
            return idUnidade;
        }

        public void SetIdUnidade(int value)
        {
            idUnidade = value;
        }

        public int GetQtdVagas()
        {
            return qtdVagas;
        }

        public void SetQtdVagas(int value)
        {
            qtdVagas = value;
        }

        public string GetIdentificacao()
        {
            return identificacao;
        }

        public void SetIdentificacao(string value)
        {
            identificacao = value;
        }

        public bool GetStatusInadimplencia()
        {
            return statusInadimplencia;
        }

        public void SetStatusInadimplencia(bool value)
        {
            statusInadimplencia = value;
        }

        public bool GetStatusOcupacao()
        {
            return statusOcupacao;
        }

        public void SetStatusOcupacao(bool value)
        {
            statusOcupacao = value;
        }

        public int GetIdCondominio()
        {
            return idCondominio;
        }

        public void SetIdCondominio(int value)
        {
            idCondominio = value;
        }

        public int GetIdCliente()
        {
            return idCliente;
        }

        public void SetIdCliente(int value)
        {
            idCliente = value;
        }
    }
    //TODO: criar métodos da classe Unidade
}
