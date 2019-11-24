using System;
using System.Collections.Generic;
using System.Data;
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
                                `valorReservaEspacoDiaria`, `regulamentoReservaEspaco`, `idCondominio`)
                                VALUES ('{0}', {1}, {2}, '{3}', {4})",
                espacoLazer.GetNomeEspacoLazer(),
                espacoLazer.GetAreaEspacoLazer(),
                espacoLazer.GetValorReserva(),
                espacoLazer.GetRegulamentoReservaEspaco(),
                espacoLazer.GetIdCondominio()); 

            MetodosBD.ExecutaSQL(SQL);
        }

        internal static DataTable PesquisarEspacoLazerPorNome(string nomeEspaco, int idCondominio)
        {
            string SQL;
            DataTable dt;
            SQL = String.Format(@"SELECT * FROM `EspacoLazer`
                                  WHERE `nomeEspacoLazer` = '{0}'
                                  AND `idCondominio` = {1};",
                                  nomeEspaco,
                                  idCondominio);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }
    }
}