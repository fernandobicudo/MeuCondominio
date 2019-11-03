using MeuCondominio2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace MeuCondominio2.Services.Unidade
{
    public class BuscaUnidade
    {
        public DataTable BuscarUnidade()
        {
            return DAOUnidade.SelecionarUnidade();
        }

        public DataTable BuscarUnidadePorCondominoDoCondominio(int idCondomino, int idCondominio)
        {
            return DAOUnidade.SelecionarUnidadePorCondominoDoCondominio(idCondomino, idCondominio);
        }

        public DataTable BuscarUnidadePorCondominio(int idCondominio)
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
