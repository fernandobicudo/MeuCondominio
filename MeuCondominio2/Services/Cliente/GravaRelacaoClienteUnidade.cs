using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Cliente
{
    public class GravaRelacaoClienteUnidade
    {
        public void GravarRelacaoClienteUnidade(RelacaoClienteUnidade relacaoClienteUnidade)
        {
            DAORelacaoClienteUnidade.DAOInserirRelacaoClienteUnidade(relacaoClienteUnidade);
        }
    }
}
