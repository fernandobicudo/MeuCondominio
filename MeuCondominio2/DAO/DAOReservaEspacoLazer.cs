using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;

namespace MeuCondominio2.DAO
{
    public class DAOReservaEspacoLazer
    {
        public static void InserirReservaEspacoLazer(Model.ReservaEspacoLazer reservaEspacoLazer)
        {
            string SQL;
            Formatadores formatadores = new Formatadores();

            string dataReserva = formatadores.ConversaoDeDataParaStringMySQL(reservaEspacoLazer.GetDataReserva());


            SQL = String.Format(@"INSERT INTO `ReservaEspacoLazer` (`dtReserva`, `idUnidade`, `idEspacoLazer`)
                                VALUES ('{0}', {1}, {2}); ",
                                dataReserva, reservaEspacoLazer.GetIdUnidade(), reservaEspacoLazer.GetIdEspacoLazer());

            MetodosBD.ExecutaSQL(SQL);
        }
    }
}