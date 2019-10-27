using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.ResultadoDoSorteio
{
    public class BuscaResultadoDoSorteio
    {
        public static DataTable BuscarVagasDoResultadoPorIdDoClienteEIddoCondominio(int idCliente, int idCondominio)
        {
            return DAOResultadoDoSorteio.PesquisarVagasDoResultadoPorIdDoClienteEIddoCondominio(idCliente, idCondominio);
        }
    }
}
