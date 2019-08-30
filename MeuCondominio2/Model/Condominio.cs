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
        private int QuantidadeVagasPorUnidade;


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
    }
    //TODO: criar métodos da classe Condominio
}
