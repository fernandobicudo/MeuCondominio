using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Cliente
{
    public class BuscaRelacaoClienteUnidade
    {
        public DataTable BuscarRelacaoClienteUnidade(int idCliente, int idUnidade)
        {
            DataTable dt;
            dt = DAORelacaoClienteUnidade.DAOSelecionarRelacaoClienteUnidade(idCliente, idUnidade);
            return dt;
        }
    }
}
