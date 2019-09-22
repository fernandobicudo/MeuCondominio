using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class OpcaoDeVotacaoPlebiscito 
    {
        private int idOpcaoDeVotacaoPlebiscito;
        private string nomeOpcaoDeVotacaoPlebiscito;
        private int idEleicao;
        
        public OpcaoDeVotacaoPlebiscito()
        {

        }

        public OpcaoDeVotacaoPlebiscito(int idOpcaoDeVotacaoPlebiscito, string nomeOpcaoDeVotacaoPlebiscito, int idEleicao)
        {
            this.idOpcaoDeVotacaoPlebiscito = idOpcaoDeVotacaoPlebiscito;
            this.nomeOpcaoDeVotacaoPlebiscito = nomeOpcaoDeVotacaoPlebiscito;
            this.idEleicao = idEleicao;
        }

        public int GetIdOpcaoDeVotacaoPlebiscito()
        {
            return idOpcaoDeVotacaoPlebiscito;
        }

        public void SetIdOpcaoDeVotacaoPlebiscito(int value)
        {
            idOpcaoDeVotacaoPlebiscito = value;
        }

        public string GetNomeOpcaoDeVotacaoPlebiscito()
        {
            return nomeOpcaoDeVotacaoPlebiscito;
        }

        public void SetNomeOpcaoDeVotacaoPlebiscito(string value)
        {
            nomeOpcaoDeVotacaoPlebiscito = value;
        }

        public int GetIdEleicao()
        {
            return idEleicao;
        }

        public void SetIdEleicao(int value)
        {
            idEleicao = value;
        }
    }
}
