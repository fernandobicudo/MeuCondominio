using MeuCondominio2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace MeuCondominio2.Services.Unidade
{
    public class BuscaUnidade
    {
        public static DataTable PesquisarUnidade()
        {
            return DAOUnidade.SelecionarUnidade();
        }

        public static DataTable PesquisarUnidadePorCondominoDoCondominio(int idCondomino, int idCondominio)
        {
            return DAOUnidade.SelecionarUnidadePorCondominoDoCondominio(idCondomino, idCondominio);
        }

        public static DataTable PesquisarUnidadePorCondominio(int idCondominio)
        {
            return DAOUnidade.SelecionarUnidadePorCondominio(idCondominio);
        }

        public static int ContarUnidadesPorCondominio(int idCondominio)
        {
            return DAOUnidade.ContarUnidadesPorCondominio(idCondominio);
        }
    }
}
