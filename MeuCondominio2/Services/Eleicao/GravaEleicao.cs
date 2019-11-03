using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.DAO;


namespace MeuCondominio2.Services.Eleicao
{
    public class GravaEleicao
    {
        public void GravaEleicaoDoCondominio(Model.Eleicao eleicao)
        {
            DAOEleicao.InserirEleicao(eleicao);
        }
    }
}
