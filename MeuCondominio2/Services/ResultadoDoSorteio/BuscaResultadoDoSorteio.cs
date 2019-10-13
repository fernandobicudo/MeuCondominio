using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.ResultadoDoSorteio
{
    public class BuscaResultadoDoSorteio
    {
        public static DataTable BuscarVagasDoResultadoPorIdDoClienteEIddoCondominio(int idCondomino, int idCondominio)
        {
            return DAOResultadoDoSorteio.PesquisarVagasDoResultadoPorIddoCondominoEIddoCondominio(idCondomino, idCondominio);
        }
    }
}
