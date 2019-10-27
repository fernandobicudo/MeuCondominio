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
                SQL = String.Format(@"INSERT INTO `ResultadoSorteio` (`idUnidade`, `idVagaGaragem`, `idSorteioVagas`) VALUES " +
                                    "({0}, {1}, {2})", linha.GetIdUnidade(),
                                    linha.GetIdVagaDeGaragem(), linha.GetIdSorteioVaga());

                MetodosBD.ExecutaSQL(SQL);
            }
        }

        internal static DataTable PesquisarVagasDoResultadoPorIdDoClienteEIddoCondominio(int idCliente, int idCondominio)
        {
            string SQL;
            SQL = String.Format(@"SELECT * FROM `ResultadoSorteio` rs " +
                                "JOIN `SorteioVagas` sv ON sv.idSorteioVagas = rs.idSorteioVagas " +
                                "JOIN `Unidade` un ON un.idUnidade = rs.idUnidade " +
                                "JOIN `VagaGaragem` vg ON vg.idVagaGaragem = rs.idVagaGaragem " +
                                "WHERE sv.idCondominio = {0} " +
                                "AND un.idCliente = {1} " +
                                "AND sv.idSorteioVagas = (select MAX(idSorteioVagas) from `SorteioVagas`);", idCondominio, idCliente);
            //TODO: select considerando que condômino terá apenas uma unidade: ajustar para que resultado seja vinculado a uma unidade específica.
            //TODO: SELECT trazendo quantas vagas tiverem sido sorteadas para a unidade no mesmo sorteio. É necessário trigger para apagar os resultados anteriores para o mesmo sorteio ou exibir apenas os últimos resultados em número de vagas sorteadas. 
            return MetodosBD.ExecutaSelect(SQL);
        }
    }

}
