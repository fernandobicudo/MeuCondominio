using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class OpcaoDeVotacaoPlebiscito :OpcaoVotacao
    {
        private int idOpcaoDeVotacaoPlebiscito;
        private int idOpcaoIndividualDeVotacaoPlebiscito;
        private string descricaoOpcaoDeVotacaoPlebiscitoIndividual;

        
        public OpcaoDeVotacaoPlebiscito()
        {

        }

        public OpcaoDeVotacaoPlebiscito(string descricaoOpcaoDeVotacaoPlebiscitoIndividual)
        {
            this.descricaoOpcaoDeVotacaoPlebiscitoIndividual = descricaoOpcaoDeVotacaoPlebiscitoIndividual;
        }

        public OpcaoDeVotacaoPlebiscito(int idOpcaoDeVotacaoPlebiscito, int idOpcaoIndividuaDeVotacaoPlebiscitol, string descricaoOpcaoDeVotacaoPlebiscitoIndividual)
        {
            this.idOpcaoDeVotacaoPlebiscito = idOpcaoDeVotacaoPlebiscito;
            this.idOpcaoIndividualDeVotacaoPlebiscito = idOpcaoIndividuaDeVotacaoPlebiscitol;
            this.descricaoOpcaoDeVotacaoPlebiscitoIndividual = descricaoOpcaoDeVotacaoPlebiscitoIndividual;
        }

        public OpcaoDeVotacaoPlebiscito(int idOpcaoIndividualDeVotacaoPlebiscito, string descricaoOpcaoDeVotacaoPlebiscitoIndividual)
        {
            this.idOpcaoIndividualDeVotacaoPlebiscito = idOpcaoIndividualDeVotacaoPlebiscito;
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

        public int GetIdOpcaoIndividualDeVotacaoPlebiscito()
        {
            return idOpcaoIndividualDeVotacaoPlebiscito;
        }

        public void SetIdOpcaoIndividualDeVotacaoPlebiscito(int value)
        {
            idOpcaoIndividualDeVotacaoPlebiscito = value;
        }

        public string GetDescricaoOpcaoIndividualDeVotacaoPlebiscito()
        {
            return descricaoOpcaoDeVotacaoPlebiscitoIndividual;
        }

        public void SetDescricaoOpcaoIndividualDeVotacaoPlebiscito(string value)
        {
            descricaoOpcaoDeVotacaoPlebiscitoIndividual = value;
        }
    }
}
