using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using System.Data;
using MeuCondominio2.Services.Ferramentas;

namespace MeuCondominio2.DAO
{
    public class DAOSorteioVagas
    {
        public static void InserirSorteioVagas(SorteioVagas sorteioVagas)
        {
            string SQL;

            Formatadores formatadores = new Formatadores();

            string dataSorteio = formatadores.ConversaoDeDataParaStringMySQL(sorteioVagas.GetDataSorteio());
            string dataValidadeInicio = formatadores.ConversaoDeDataParaStringMySQL(sorteioVagas.GetDataValidadeSorteioInicio());
            string dataValidadeFim = formatadores.ConversaoDeDataParaStringMySQL(sorteioVagas.GetDataValidadeSorteioFim());

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
                                "WHERE sv.idSorteioVagas = {0};", idSorteio);
            //TODO: verificar comportamento do select para pesquisar número de vagas por unidade do sorteio. Uma das cláusulas where nao é necessária.
            dt = MetodosBD.ExecutaSelect(SQL);

            int qtdeVagas = Convert.ToInt32(dt.Rows[0]["qtdeVagasPorUnidade"]);

            return qtdeVagas;
        }

        internal static DataTable PesquisarIdDoResultadoDoUltimoSorteioParaOCondominio(int idCondominio)
        {
            string SQL;
            SQL = String.Format(@"SELECT sv.idSorteioVagas FROM `SorteioVagas` sv " +
                                "WHERE sv.idCondominio = {0} " +
                                "AND sv.idSorteioVagas = (select MAX(idSorteioVagas) from `SorteioVagas`);", idCondominio);

            return MetodosBD.ExecutaSelect(SQL);

        }

    }
}