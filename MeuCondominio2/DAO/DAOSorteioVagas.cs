using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using System.Data;

namespace MeuCondominio2.DAO
{
    public class DAOSorteioVagas
    {
        public static void InserirSorteioVagas(SorteioVagas sorteioVagas)
        {
            string SQL;

            string dataSorteio = sorteioVagas.GetDataSorteio().ToString().Replace('/', '-');
            string dataValidadeInicio = sorteioVagas.GetDataValidadeSorteioInicio().ToString().Replace('/', '-');
            string dataValidadeFim = sorteioVagas.GetDataValidadeSorteioFim().ToString().Replace('/', '-');

            SQL = String.Format(@"INSERT INTO SorteioVagas " +
                "(`tipoSorteio`, `dataSorteio`, `dataValidadeSorteioInicio`, `dataValidadeSorteioFim`, " +
                "`associarVagasSequenciais`, `idCondominio`, `qtdeVagasPorUnidade`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6});", 
                sorteioVagas.GetTipoSorteio(), dataSorteio, dataValidadeInicio, dataValidadeFim, sorteioVagas.GetAssociacaoVagasSequenciais(), sorteioVagas.GetIdCondominio(),
                sorteioVagas.GetQtdeVagasPorUnidade());

            MetodosBD.ExecutaSQL(SQL);

        }

        internal static int PesquisarNumeroDeVagasPorUnidadeDoSorteio(int idSorteio)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT sv.qtdeVagasPorUnidade FROM `SorteioVagas` sv " +
                                "WHERE sv.id = {0} " +
                                "AND sv.id = (select MAX(id) from `SorteioVagas`);", idSorteio);

            dt = MetodosBD.ExecutaSelect(SQL);

            int qtdeVagas = Convert.ToInt32(dt.Rows[0]["qtdeVagasPorUnidade"]);

            return qtdeVagas;
        }

        internal static DataTable PesquisarIdDoResultadoDoUltimoSorteioParaOCondominio(int idCondominio)
        {
            string SQL;
            SQL = String.Format(@"SELECT sv.id FROM `SorteioVagas` sv " +
                                "WHERE sv.idCondominio = {0} " +
                                "AND sv.id = (select MAX(id) from `SorteioVagas`);", idCondominio);

            return MetodosBD.ExecutaSelect(SQL);

        }

    }
}