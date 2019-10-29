using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.Cliente
{
    public class BuscaCliente
    {
        public static DataTable BuscarClientePorCPF(string CPF)
        {
            return DAOCliente.PesquisarClientePorCPF(CPF);
        }

        public static DataTable BuscarClientePorIDRetornandoSuasUnidadesECondominios(int idCliente)
        {
            return DAOCliente.PesquisarClientePorIDRetornandoSuasUnidadesECondominios(idCliente);
        }
    }
}
