using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio2.Model
{
    public class ReservaEspacoLazer
    {
        private int idReservaEspacoLazer;
        private DateTime dataReserva;
        private int idUnidade;
        private int idEspacoLazer;

        public ReservaEspacoLazer(int idReservaEspacoLazer, DateTime dataReserva, int idUnidade, int idEspacoLazer)
        {
            this.idReservaEspacoLazer = idReservaEspacoLazer;
            this.dataReserva = dataReserva;
            this.idUnidade = idUnidade;
            this.idEspacoLazer = idEspacoLazer;
        }

        public ReservaEspacoLazer(DateTime dataReserva, int idUnidade, int idEspacoLazer)
        {
            this.dataReserva = dataReserva;
            this.idUnidade = idUnidade;
            this.idEspacoLazer = idEspacoLazer;
        }

        public int GetIdReservaEspacoLazer()
        {
            return idReservaEspacoLazer;
        }

        public void SetIdReservaEspacoLazer(int value)
        {
            idReservaEspacoLazer = value;
        }

        public DateTime GetDataReserva()
        {
            return dataReserva;
        }

        public void SetDataReserva(DateTime value)
        {
            dataReserva = value;
        }

        public int GetIdUnidade()
        {
            return idUnidade;
        }

        public void SetIdUnidade(int value)
        {
            idUnidade = value;
        }
        public int GetIdEspacoLazer()
        {
            return idEspacoLazer;
        }

        public void SetIdEspacoLazer(int value)
        {
            idEspacoLazer = value;
        }
    }
}