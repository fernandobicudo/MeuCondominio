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
        private int idEleicao;

        public int GetIdEleicao()
        {
            return idEleicao;
        }

        public void SetIdEleicao(int value)
        {
            idEleicao = value;
        }

        public OpcaoVotacao()
        {

        }

        public OpcaoVotacao(int idOpcaoDeVotacao, string nomeOpcaoDeVotacao,
            string descricaoOpcaoDeVotacao, string uRLFotoDaOpcao, int idEleicao)
        {
            this.idOpcaoDeVotacao = idOpcaoDeVotacao;
            this.nomeOpcaoDeVotacao = nomeOpcaoDeVotacao;
            this.descricaoOpcaoDeVotacao = descricaoOpcaoDeVotacao;
            URLFotoDaOpcao = uRLFotoDaOpcao;
            this.idEleicao = idEleicao;
        }

        public OpcaoVotacao(string nomeOpcaoDeVotacao, string descricaoOpcaoDeVotacao,
            string uRLFotoDaOpcao, int idEleicao)
        {
            this.nomeOpcaoDeVotacao = nomeOpcaoDeVotacao;
            this.descricaoOpcaoDeVotacao = descricaoOpcaoDeVotacao;
            URLFotoDaOpcao = uRLFotoDaOpcao;
            this.idEleicao = idEleicao;
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

        public string GetURLFotoDaOpcao()
        {
            return URLFotoDaOpcao;
        }

        public void SetURLFotoDaOpcao(string value)
        {
            URLFotoDaOpcao = value;
        }
    }
}
