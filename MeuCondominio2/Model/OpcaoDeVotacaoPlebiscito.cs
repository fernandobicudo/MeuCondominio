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

        public int IdOpcaoDeVotacaoPlebiscito { get => idOpcaoDeVotacaoPlebiscito; set => idOpcaoDeVotacaoPlebiscito = value; }
        public string NomeOpcaoDeVotacaoPlebiscito { get => nomeOpcaoDeVotacaoPlebiscito; set => nomeOpcaoDeVotacaoPlebiscito = value; }
        public int IdEleicao { get => idEleicao; set => idEleicao = value; }

        public OpcaoDeVotacaoPlebiscito()
        {

        }

        public OpcaoDeVotacaoPlebiscito(int idOpcaoDeVotacaoPlebiscito, string nomeOpcaoDeVotacaoPlebiscito, int idEleicao)
        {
            this.idOpcaoDeVotacaoPlebiscito = idOpcaoDeVotacaoPlebiscito;
            this.nomeOpcaoDeVotacaoPlebiscito = nomeOpcaoDeVotacaoPlebiscito;
            this.idEleicao = idEleicao;
        }
    }
}

#region antigos getters/setters
/*
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
*/
#endregion
