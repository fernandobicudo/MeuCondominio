using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;

namespace MeuCondominio2.DAO
{
    public class DAORelacaoClienteUnidade
    {
        public static void DAOInserirRelacaoClienteUnidade (RelacaoClienteUnidade relacaoClienteUnidade)
        {
            
            string SQL;
            SQL = String.Format(@"INSERT INTO `RelacaoClienteUnidade` " +
                                "(`idCliente`, `idUnidade`, `MoradorDaUnidade`,`ProprietarioDaUnidade`) " +
                                "VALUES ({0}, {1}, {2}, {3});", relacaoClienteUnidade.GetIdCliente(), relacaoClienteUnidade.GetIdUnidade(),
                                relacaoClienteUnidade.GetEhMoradorDaUnidade(), relacaoClienteUnidade.GetEhProprietarioDaUnidade());
            MetodosBD.ExecutaSQL(SQL);
        }

        public static DataTable DAOSelecionarRelacaoClienteUnidade(int idCliente, int idUnidade)
        {
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `RelacaoClienteUnidade` WHERE idCliente = {0} AND idUnidade = {1};", idCliente, idUnidade);
            dt = MetodosBD.ExecutaSelect(SQL);
            return dt;
        }
    }
}
