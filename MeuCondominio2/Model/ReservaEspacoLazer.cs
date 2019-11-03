using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio2.Model
{
    public class ReservaEspacoLazer
    {
        private int idReservaEspacoLazer { get; set; }
        private DateTime dataReserva { get; set; }
        private int idUnidade { get; set; }

        public ReservaEspacoLazer(int idReservaEspacoLazer, DateTime dataReserva, int idUnidade)
        {
            this.idReservaEspacoLazer = idReservaEspacoLazer;
            this.dataReserva = dataReserva;
            this.idUnidade = idUnidade;
        }

        public ReservaEspacoLazer(DateTime dataReserva, int idUnidade)
        {
            this.dataReserva = dataReserva;
            this.idUnidade = idUnidade;
        }

    }
}