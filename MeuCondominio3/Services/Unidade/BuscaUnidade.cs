using MeuCondominio2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace MeuCondominio2.Services.Unidade
{
    public class BuscaUnidade
    {
        public static DataTable BuscarUnidade()
        {
            return DAOUnidade.SelecionarUnidade();
        }

        public static DataTable BuscarUnidadePorCondominoDoCondominio(int idCondomino, int idCondominio)
        {
            return DAOUnidade.SelecionarUnidadePorCondominoDoCondominio(idCondomino, idCondominio);
        }

        public static DataTable BuscarUnidadePorCondominio(int idCondominio)
        {
            return DAOUnidade.SelecionarUnidadePorCondominio(idCondominio);
        }

        public static int ContarUnidadesPorCondominio(int idCondominio)
        {
            return DAOUnidade.ContarUnidadesPorCondominio(idCondominio);
        }

        public static int BuscarUnidadePorDescricao(string descricao)
        {
            int idUnidade;
            idUnidade = DAOUnidade.SelecionarUnidade(descricao);
            return idUnidade;
        }
    }
}
