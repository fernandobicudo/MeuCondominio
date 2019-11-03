using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Condominio
{
    public class BuscaCondominio
    {
        public DataTable BuscarCondominioPorIdDoCliente(int idCliente)
        {
            return DAOCondominio.PesquisarCondominioPorIdDoCliente(idCliente);
        }

        public DataTable BuscarCondominioPorId(int idCondominio)
        {
            return DAOCondominio.PesquisarCondominioPorIdDoCondominio(idCondominio);
        }
    }
}
