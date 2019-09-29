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
        private int idCondomino;

        

        public Unidade()
        {

        }

        public Unidade(int idUnidade,
            int qtdVagas,
            string identificacao,
            bool statusInadimplencia,
            bool statusOcupacao,
            int idCondominio,
            int idCondomino)
        {
            this.idUnidade = idUnidade;
            this.qtdVagas = qtdVagas;
            this.identificacao = identificacao;
            this.statusInadimplencia = statusInadimplencia;
            this.statusOcupacao = statusOcupacao;
            this.idCondominio = idCondominio;
            this.idCondomino = idCondomino;
        }

        public Unidade(int qtdVagas,
            string identificacao,
            bool statusInadimplencia,
            bool statusOcupacao,
            int idCondominio,
            int idCondomino)
        {
            this.qtdVagas = qtdVagas;
            this.identificacao = identificacao;
            this.statusInadimplencia = statusInadimplencia;
            this.statusOcupacao = statusOcupacao;
            this.idCondominio = idCondominio;
            this.idCondomino = idCondomino;
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

        public int GetIdCondomino()
        {
            return idCondomino;
        }

        public void SetIdCondomino(int value)
        {
            idCondomino = value;
        }
    }
    //TODO: criar métodos da classe Unidade
}
