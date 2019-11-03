using MeuCondominio2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.Services.VagaGaragem
{
    public class BuscaVagaGaragem
    {
        public DataTable PesquisarVagaGaragem()
        {
            return DAOVagaGaragem.SelecionarVagaGaragem();
        }

        public DataTable PesquisarVagaGaragem(int id)
        {
            return DAOVagaGaragem.SelecionarVagaGaragem(id);
        }

        public DataTable PesquisarVagasGaragemPorCondominio(int idCondominio)
        {
            return DAOVagaGaragem.SelecionarVagasGaragemPorCondominio(idCondominio);
        }
    }
}
