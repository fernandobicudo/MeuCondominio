using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;

namespace MeuCondominio2.DAO
{
    class DAOResultadoDoSorteio
    {
        internal static void InserirResultadoDoSorteio(List<ResultadoSorteioPorUnidade> lista)
        {

            string SQL;


            foreach (ResultadoSorteioPorUnidade linha in lista)
            {
                SQL = String.Format(@"INSERT INTO `ResultadoSorteio` (`idUnidade`, `idVagaGaragem`, `idSorteioVaga`) VALUES " +
                                    "({0}, {1}, {2})", linha.GetIdUnidade(),
                                    linha.GetIdVagaDeGaragem(), linha.GetIdSorteioVaga());

                MetodosBD.ExecutaSQL(SQL);

            }
        }

        internal static DataTable PesquisarVagasDoResultadoPorIddoCondominoEIddoCondominio(int idCondomino, int idCondominio)
        {
            string SQL;
            SQL = String.Format(@"SELECT vg.numeracao FROM `ResultadoSorteio` rs " +
                                "JOIN `SorteioVagas` sv ON sv.id = rs.idSorteioVaga " +
                                "JOIN `Unidade` un ON un.id = rs.idUnidade " +
                                "JOIN `VagaGaragem` vg ON vg.id = rs.idVagaGaragem " +
                                "WHERE sv.idCondominio = {0} " +
                                "AND un.idCondomino = {1} " +
                                "AND sv.id = (select MAX(id) from `SorteioVagas`);", idCondominio, idCondomino);

            return MetodosBD.ExecutaSelect(SQL);
        }
    }
}
