using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    class OpcaoDeVotacaoPlebiscito :OpcaoVotacao
    {
        private int idOpcaoDeVotacaoPlebiscito;
        private int idOpcaoDeVotacaoPlebiscitoIndividual;
        private string descricaoOpcaoDeVotacaoPlebiscitoIndividual;

        
        public OpcaoDeVotacaoPlebiscito()
        {
        }

        public OpcaoDeVotacaoPlebiscito(int idOpcaoDeVotacaoPlebiscito, int idOpcaoDeVotacaoPlebiscitoIndividual, string descricaoOpcaoDeVotacaoPlebiscitoIndividual)
        {
            this.idOpcaoDeVotacaoPlebiscito = idOpcaoDeVotacaoPlebiscito;
            this.idOpcaoDeVotacaoPlebiscitoIndividual = idOpcaoDeVotacaoPlebiscitoIndividual;
            this.descricaoOpcaoDeVotacaoPlebiscitoIndividual = descricaoOpcaoDeVotacaoPlebiscitoIndividual;
        }

        public OpcaoDeVotacaoPlebiscito(int idOpcaoDeVotacaoPlebiscitoIndividual, string descricaoOpcaoDeVotacaoPlebiscitoIndividual)
        {
            this.idOpcaoDeVotacaoPlebiscitoIndividual = idOpcaoDeVotacaoPlebiscitoIndividual;
            this.descricaoOpcaoDeVotacaoPlebiscitoIndividual = descricaoOpcaoDeVotacaoPlebiscitoIndividual;
        }

        public int GetIdOpcaoDeVotacaoPlebiscito()
        {
            return idOpcaoDeVotacaoPlebiscito;
        }

        public void SetIdOpcaoDeVotacaoPlebiscito(int value)
        {
            idOpcaoDeVotacaoPlebiscito = value;
        }

        public int GetIdOpcaoDeVotacaoPlebiscitoIndividual()
        {
            return idOpcaoDeVotacaoPlebiscitoIndividual;
        }

        public void SetIdOpcaoDeVotacaoPlebiscitoIndividual(int value)
        {
            idOpcaoDeVotacaoPlebiscitoIndividual = value;
        }

        public string GetDescricaoOpcaoDeVotacaoPlebiscitoIndividual()
        {
            return descricaoOpcaoDeVotacaoPlebiscitoIndividual;
        }

        public void SetDescricaoOpcaoDeVotacaoPlebiscitoIndividual(string value)
        {
            descricaoOpcaoDeVotacaoPlebiscitoIndividual = value;
        }
    }
}
