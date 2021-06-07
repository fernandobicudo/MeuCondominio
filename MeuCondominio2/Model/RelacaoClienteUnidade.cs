using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class RelacaoClienteUnidade
    {
        private int idCliente;
        private int idUnidade;
        private string CPF;
        private bool ehMoradorDaUnidade;
        private bool ehProprietarioDaUnidade;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdUnidade { get => idUnidade; set => idUnidade = value; }
        public string CPF1 { get => CPF; set => CPF = value; }
        public bool EhMoradorDaUnidade { get => ehMoradorDaUnidade; set => ehMoradorDaUnidade = value; }
        public bool EhProprietarioDaUnidade { get => ehProprietarioDaUnidade; set => ehProprietarioDaUnidade = value; }


        public RelacaoClienteUnidade(int idCliente, int idUnidade, string cPF, bool ehMoradorDaUnidade, bool ehProprietarioDaUnidade)
        {
            this.idCliente = idCliente;
            this.idUnidade = idUnidade;
            CPF = cPF;
            this.ehMoradorDaUnidade = ehMoradorDaUnidade;
            this.ehProprietarioDaUnidade = ehProprietarioDaUnidade;
        }

        public RelacaoClienteUnidade(string cPF, bool ehMoradorDaUnidade, bool ehProprietarioDaUnidade)
        {
            CPF = cPF;
            this.ehMoradorDaUnidade = ehMoradorDaUnidade;
            this.ehProprietarioDaUnidade = ehProprietarioDaUnidade;
        }

        public RelacaoClienteUnidade()
        {

        }
    }
}

#region antigos getters/setters
/*
public string GetCPF1()
{
    return CPF;
}

public void SetCPF1(string value)
{
    CPF = value;
}


public int GetIdCliente()
{
    return idCliente;
}

public void SetIdCliente(int value)
{
    idCliente = value;
}

public int GetIdUnidade()
{
    return idUnidade;
}

public void SetIdUnidade(int value)
{
    idUnidade = value;
}

public bool GetEhMoradorDaUnidade()
{
    return ehMoradorDaUnidade;
}

public void SetEhMoradorDaUnidade(bool value)
{
    ehMoradorDaUnidade = value;
}

public bool GetEhProprietarioDaUnidade()
{
    return ehProprietarioDaUnidade;
}

public void SetEhProprietarioDaUnidade(bool value)
{
    ehProprietarioDaUnidade = value;
}
*/
#endregion