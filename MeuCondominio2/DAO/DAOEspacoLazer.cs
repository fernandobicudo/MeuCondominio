using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeuCondominio2.Model;

namespace MeuCondominio2.DAO
{
    public class DAOEspacoLazer
    {
        internal static void InserirEspacoLazer(EspacoLazer espacoLazer)
        {
            string SQL;
            SQL = String.Format(@"INSERT INTO `EspacoLazer` (`nomeEspacoLazer`, `areaEspacoMetrosQuadrados`,
                                `valorReservaEspacoDiaria`, `idCondominio`)
                                VALUES ('{0}', {1}, {2}, {3})",
                espacoLazer.GetNomeEspacoLazer(),
                espacoLazer.GetAreaEspacoLazer(),
                espacoLazer.GetValorReserva(),
                espacoLazer.GetIdCondominio());

            MetodosBD.ExecutaSQL(SQL);
        }
    }
}