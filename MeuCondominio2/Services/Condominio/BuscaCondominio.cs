using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.DAO;

namespace MeuCondominio2.Services.Condominio
{
    public class BuscaCondominio
    {
        public static DataTable BuscarCondominioPorIddoCondomino(int idCondomino)
        {
            return DAOCondominio.PesquisarCondominioPorIddoCondomino(idCondomino);
        }

        public static DataTable BuscarCondominioPorId(int idCondominio)
        {
            return DAOCondominio.PesquisarCondominioPorIdDoCondominio(idCondominio);
        }
    }
}
