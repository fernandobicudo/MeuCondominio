using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class Condominio
    {
        private int idCondominio;
        private string CNPJ;
        private string nomeCondominio;
        private int QuantidadeVagasPorUnidade; //TODO: revisar se o atributo de Quantidade de Vagas por  Unidade permanece ou não no Condominio.

        public int IdCondominio { get => idCondominio; set => idCondominio = value; }
        public string CNPJ1 { get => CNPJ; set => CNPJ = value; }
        public string NomeCondominio { get => nomeCondominio; set => nomeCondominio = value; }
        public int QuantidadeVagasPorUnidade1 { get => QuantidadeVagasPorUnidade; set => QuantidadeVagasPorUnidade = value; }

        public Condominio()
        {
        }

        public Condominio(int idCondominio, string cNPJ, string nomeCondominio, int quantidadeVagasPorUnidade)
        {
            this.idCondominio = idCondominio;
            CNPJ = cNPJ;
            this.nomeCondominio = nomeCondominio;
            QuantidadeVagasPorUnidade = quantidadeVagasPorUnidade;
        }

        public Condominio(string cNPJ, string nomeCondominio, int quantidadeVagasPorUnidade)
        {
            CNPJ = cNPJ;
            this.nomeCondominio = nomeCondominio;
            QuantidadeVagasPorUnidade = quantidadeVagasPorUnidade;
        }

        #region antigos getters/setters
        /*
        public int GetIdCondominio()
        {
            return idCondominio;
        }

        public void SetIdCondominio(int value)
        {
            idCondominio = value;
        }

        public string GetCNPJCondominio()
        {
            return CNPJ;
        }

        public void SetCNPJCondominio(string value)
        {
            CNPJ = value;
        }

        public string GetNomeCondominio()
        {
            return nomeCondominio;
        }

        public void SetNomeCondominio(string value)
        {
            nomeCondominio = value;
        }

        public int GetQuantidadeVagasPorUnidade1()
        {
            return QuantidadeVagasPorUnidade;
        }

        public void SetQuantidadeVagasPorUnidade1(int value)
        {
            QuantidadeVagasPorUnidade = value;
        }
        */
        #endregion
    }
    //TODO: criar métodos da classe Condominio
}
