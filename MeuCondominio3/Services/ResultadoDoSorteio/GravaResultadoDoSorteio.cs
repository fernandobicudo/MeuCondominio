using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.ResultadoDoSorteio
{
    public class GravaResultadoDoSorteio
    {
        internal static void GravarResultadoDoSorteio(List<ResultadoSorteioPorUnidade> resultado)
        {
            DAOResultadoDoSorteio.InserirResultadoDoSorteio(resultado);
        }
    }
}
