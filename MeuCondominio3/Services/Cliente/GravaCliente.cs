using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.DAO;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.Cliente
{
    public class GravaCliente
    {
        public static void ImportarClientesDeLista(List<Model.Cliente> listaClientes)
        {
            DAOCliente.InserirClientesEmLote(listaClientes);
        }
    }
}
