using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services;
namespace MeuCondominio2.DAO
{
    public class DAOCondomino
    {
        public void ImportarDadosDosCondominosDoCondominio(List<Condomino> listaDeCondominos)
        {
            foreach(Condomino condomino in listaDeCondominos)
            {
                string senha;

                senha = Criptografia.Encriptar(condomino.GetSenha());

                string SQL;

                SQL = String.Format(@"INSERT INTO `Usuario` (`nome`, `telefone`, `email`, `senha`, `endereco`, `numero_endereco`, " +
                                   "`complementoEndereco`, `bairro`, `cidade`, `UF`, `CEP`, `tipo_usuario`) VALUES " +
                                   " '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', {11}",
                                   condomino.GetNome(), condomino.GetTelefone(), condomino.GetEmail(), senha, condomino.
            }
        }
    }
}
