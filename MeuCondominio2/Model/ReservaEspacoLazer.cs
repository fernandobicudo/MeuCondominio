using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio2.Model
{
    public class ReservaEspacoLazer
    {
        private int idReservaEspacoLazer;
        private DateTime dataInicioReserva;
        private DateTime dataFimReserva;
        private int idUnidade;
        private int idEspacoLazer;

        public ReservaEspacoLazer()
        {
        }

        public ReservaEspacoLazer(DateTime dataInicioReserva, DateTime dataFimReserva, int idUnidade, int idEspacoLazer)
        {
            this.dataInicioReserva = dataInicioReserva;
            this.dataFimReserva = dataFimReserva;
            this.idUnidade = idUnidade;
            this.idEspacoLazer = idEspacoLazer;
        }

        public ReservaEspacoLazer(int idReservaEspacoLazer, DateTime dataInicioReserva, DateTime dataFimReserva, int idUnidade, int idEspacoLazer)
        {
            this.idReservaEspacoLazer = idReservaEspacoLazer;
            this.dataInicioReserva = dataInicioReserva;
            this.dataFimReserva = dataFimReserva;
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

        public DateTime GetDataInicioReserva()
        {
            return dataInicioReserva;
        }

        public void SetDataInicioReserva(DateTime value)
        {
            dataInicioReserva = value;
        }

        public DateTime GetDataFimReserva()
        {
            return dataFimReserva;
        }

        public void SetDataFimReserva(DateTime value)
        {
            dataFimReserva = value;
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