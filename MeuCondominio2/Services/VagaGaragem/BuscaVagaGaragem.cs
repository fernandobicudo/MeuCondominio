using MeuCondominio2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.Services.VagaGaragem
{
    public class BuscaVagaGaragem
    {
        public static DataTable PesquisarVagaGaragem()
        {
            return DAOVagaGaragem.SelecionarVagaGaragem();
        }

        public static DataTable PesquisarVagaGaragem(int id)
        {
            return DAOVagaGaragem.SelecionarVagaGaragem(id);
        }

        public static DataTable PesquisarVagasGaragemPorCondominio(int id)
        {
            return DAOVagaGaragem.SelecionarVagasGaragemPorCondominio(id);
        }


    }
}
