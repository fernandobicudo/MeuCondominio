using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services;

namespace MeuCondominio2.DAO
{
    public class DAOVoto
    {
        public static void InserirVotoDaEleicao(Voto voto)
        {
            string SQL = String.Format(@"INSERT INTO `Voto` (`idOpcaoVotada`, `idEleicao`, `idUnidade`) " +
                "VALUES ({0}, {1}, {2});", voto.GetIdOpcaoVotada(), voto.GetIdEleicao(), voto.GetIdUnidade());
            MetodosBD.ExecutaSQL(SQL);
        }
    }
}
