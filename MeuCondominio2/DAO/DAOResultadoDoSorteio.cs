using System;
using System.Collections.Generic;
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
    }
}
