using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Sindico
{
    public class BuscaSindico
    {
        public DataTable PesquisarSindico(int idSindico)
        {
            return DAOSindico.SelecionarSindico(idSindico);
        }
    }
}
