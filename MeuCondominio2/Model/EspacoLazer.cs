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
        private int idCondominio;

        public EspacoLazer(string nomeEspacoLazer, int areaEspacoLazer, double valorReserva, int idCondominio)
        {
            this.nomeEspacoLazer = nomeEspacoLazer;
            this.areaEspacoLazer = areaEspacoLazer;
            this.valorReserva = valorReserva;
            this.idCondominio = idCondominio;
        }

        public EspacoLazer(int idEspacoLazer, string nomeEspacoLazer, int areaEspacoLazer, double valorReserva, int idCondominio)
        {
            this.idEspacoLazer = idEspacoLazer;
            this.nomeEspacoLazer = nomeEspacoLazer;
            this.areaEspacoLazer = areaEspacoLazer;
            this.valorReserva = valorReserva;
            this.idCondominio = idCondominio;
        }

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
    }
}