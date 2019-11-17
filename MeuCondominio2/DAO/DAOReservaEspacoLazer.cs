using System;
using System.Collections.Generic;
using System.Data;
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

        internal static DataTable PesquisarReservaEspacoLazer(int idUsuario, int idCondominio)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `ReservaEspacoLazer` re 
                                JOIN `EspacoLazer` el ON el.idEspacoLazer = re.idEspacoLazer 
                                JOIN `Condominio` co ON co.idCondominio = el.idCondominio 
                                WHERE co.idCondominio = {0} 
                                AND re.idUnidade = {1};", idCondominio, idUsuario);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }
    }
}