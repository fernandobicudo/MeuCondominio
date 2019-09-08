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

            SQL = String.Format(@"INSERT INTO SorteioVagas " +
                "(`tipoSorteio`, `dataSorteio`, `dataValidadeSorteioInicio`, `dataValidadeSorteioFim`, " +
                "`associarVagasSequenciais`, `idCondominio`, `qtdeVagasPorUnidade`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6});", 
                sorteioVagas.GetTipoSorteio(), sorteioVagas.GetDataSorteio(), sorteioVagas.GetDataValidadeSorteioInicio(),
                sorteioVagas.GetDataValidadeSorteioFim(), sorteioVagas.GetAssociacaoVagasSequenciais(), sorteioVagas.GetIdCondominio(),
                sorteioVagas.GetQtdeVagasPorUnidade());

            MetodosBD.ExecutaSQL(SQL);

        }
    }
}