using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.SorteioVagas
{
    public class BuscaSorteioVagas
    {
        public DataTable BuscarIdDoResultadoDoUltimoSorteioParaOCondominio(int idCondominio)
        {
            return DAOSorteioVagas.PesquisarIdDoResultadoDoUltimoSorteioParaOCondominio(idCondominio);
        }

        public int BuscarNumeroDeVagasPorUnidadeDoSorteio(int idSorteio)
        {
            return DAOSorteioVagas.PesquisarNumeroDeVagasPorUnidadeDoSorteio(idSorteio);
        }
    }
}
