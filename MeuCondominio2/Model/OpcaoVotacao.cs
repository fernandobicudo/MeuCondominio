using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class OpcaoVotacao 
    {
        private int idOpcaoDeVotacao;
        private string nomeOpcaoDeVotacao;
        private string descricaoOpcaoDeVotacao;
        private string URLFotoDaOpcao;

        public OpcaoVotacao()
        {
        }

        public OpcaoVotacao(int idOpcaoDeVotacao, string nomeOpcaoDeVotacao, string descricaoOpcaoDeVotacao, string uRLFotoDaOpcao)
        {
            this.idOpcaoDeVotacao = idOpcaoDeVotacao;
            this.nomeOpcaoDeVotacao = nomeOpcaoDeVotacao;
            this.descricaoOpcaoDeVotacao = descricaoOpcaoDeVotacao;
            URLFotoDaOpcao = uRLFotoDaOpcao;
        }

        public OpcaoVotacao(string nomeOpcaoDeVotacao, string descricaoOpcaoDeVotacao, string uRLFotoDaOpcao)
        {
            this.nomeOpcaoDeVotacao = nomeOpcaoDeVotacao;
            this.descricaoOpcaoDeVotacao = descricaoOpcaoDeVotacao;
            URLFotoDaOpcao = uRLFotoDaOpcao;
        }

        public int GetIdOpcaoDeVotacao()
        {
            return idOpcaoDeVotacao;
        }

        public void SetIdOpcaoDeVotacao(int value)
        {
            idOpcaoDeVotacao = value;
        }

        public string GetNomeOpcaoDeVotacao()
        {
            return nomeOpcaoDeVotacao;
        }

        public void SetNomeOpcaoDeVotacao(string value)
        {
            nomeOpcaoDeVotacao = value;
        }

        public string GetDescricaoOpcaoDeVotacao()
        {
            return descricaoOpcaoDeVotacao;
        }

        public void SetDescricaoOpcaoDeVotacao(string value)
        {
            descricaoOpcaoDeVotacao = value;
        }

        public string GetURLFotoDaOpcao1()
        {
            return URLFotoDaOpcao;
        }

        public void SetURLFotoDaOpcao1(string value)
        {
            URLFotoDaOpcao = value;
        }
    }
}
