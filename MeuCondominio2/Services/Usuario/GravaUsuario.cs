
using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.DAO;


namespace MeuCondominio2.Services.Usuario
{
    public class GravaUsuario
    {
        public void GravarUsuario(Model.Cliente cliente)
        {
            DAOUsuario.InserirCliente(cliente);
        }
    }
}
