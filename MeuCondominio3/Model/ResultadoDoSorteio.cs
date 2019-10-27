using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class ResultadoDoSorteio
    {
        List<ResultadoSorteioPorUnidade> resultadoSorteio = new List<ResultadoSorteioPorUnidade>();

        public List<ResultadoSorteioPorUnidade> GetResultadoSorteio()
        {
            return resultadoSorteio;
        }

        public void SetResultadoSorteio(List<ResultadoSorteioPorUnidade> value)
        {
            resultadoSorteio = value;
        }
   }
}
