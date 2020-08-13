using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio2.Model
{
    public class EspacoLazer
    {
        private int idEspacoLazer;
        private string nomeEspacoLazer;
        private int areaEspacoLazer;
        private double valorReserva;
        private string regulamentoReservaEspaco;
        private int idCondominio;

        public int IdEspacoLazer { get => idEspacoLazer; set => idEspacoLazer = value; }
        public string NomeEspacoLazer { get => nomeEspacoLazer; set => nomeEspacoLazer = value; }
        public int AreaEspacoLazer { get => areaEspacoLazer; set => areaEspacoLazer = value; }
        public double ValorReserva { get => valorReserva; set => valorReserva = value; }
        public string RegulamentoReservaEspaco { get => regulamentoReservaEspaco; set => regulamentoReservaEspaco = value; }
        public int IdCondominio { get => idCondominio; set => idCondominio = value; }

        public EspacoLazer()
        {
        }

        public EspacoLazer(int idEspacoLazer, string nomeEspacoLazer, int areaEspacoLazer, double valorReserva, string regulamentoReservaEspaco, int idCondominio)
        {
            this.idEspacoLazer = idEspacoLazer;
            this.nomeEspacoLazer = nomeEspacoLazer;
            this.areaEspacoLazer = areaEspacoLazer;
            this.valorReserva = valorReserva;
            this.regulamentoReservaEspaco = regulamentoReservaEspaco;
            this.idCondominio = idCondominio;
        }

        public EspacoLazer(string nomeEspacoLazer, int areaEspacoLazer, double valorReserva, string regulamentoReservaEspaco, int idCondominio)
        {
            this.nomeEspacoLazer = nomeEspacoLazer;
            this.areaEspacoLazer = areaEspacoLazer;
            this.valorReserva = valorReserva;
            this.regulamentoReservaEspaco = regulamentoReservaEspaco;
            this.idCondominio = idCondominio;
        }
    }
}
#region antigos getters/setters
/*
public int GetIdEspacoLazer()
{
    return idEspacoLazer;
}

public void SetIdEspacoLazer(int value)
{
    idEspacoLazer = value;
}

public string GetNomeEspacoLazer()
{
    return nomeEspacoLazer;
}

public void SetNomeEspacoLazer(string value)
{
    nomeEspacoLazer = value;
}

public int GetAreaEspacoLazer()
{
    return areaEspacoLazer;
}

public void SetAreaEspacoLazer(int value)
{
    areaEspacoLazer = value;
}

public double GetValorReserva()
{
    return valorReserva;
}

public void SetValorReserva(double value)
{
    valorReserva = value;
}

public int GetIdCondominio()
{
    return idCondominio;
}

public void SetIdCondominio(int value)
{
    idCondominio = value;
}

public string GetRegulamentoReservaEspaco()
{
    return regulamentoReservaEspaco;
}

public void SetRegulamentoReservaEspaco(string value)
{
    regulamentoReservaEspaco = value;
}
*/
#endregion