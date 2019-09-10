using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.SorteioVagas
{
    public class BuscaSorteioVagas
    {
        public static DataTable BuscarIdDoResultadoDoUltimoSorteioParaOCondominio(int idCondominio)
        {
            return DAOSorteioVagas.PesquisarIdDoResultadoDoUltimoSorteioParaOCondominio(idCondominio);
        }

        public static int BuscarNumeroDeVagasPorUnidadeDoSorteio(int idSorteio)
        {
            return DAOSorteioVagas.PesquisarNumeroDeVagasPorUnidadeDoSorteio(idSorteio);
        }
    }
}
