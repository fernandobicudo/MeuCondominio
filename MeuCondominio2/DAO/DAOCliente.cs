using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services;
using MeuCondominio2.Services.Ferramentas;


namespace MeuCondominio2.DAO
{
    public class DAOCliente
    {
        public void ImportarDadosDosClientes(List<Cliente> listaDeClientes)
        {
            foreach(Cliente cliente in listaDeClientes)
            {
                string senha = GeradorDeSenhaProvisoria.gerador.GerarSenhaProvisoria();
                senha = Criptografia.Encriptar(cliente.GetSenha());
                string SQL;
                SQL = String.Format(@"INSERT INTO `Usuario` (`nome`, `telefone`, `email`, `senha`, `endereco`, `numero_endereco`, " +
                                   "`complementoEndereco`, `bairro`, `cidade`, `UF`, `CEP`, `tipo_usuario`) VALUES " +
                                   " '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', {11}",
                                   cliente.GetNome(), cliente.GetTelefone(), cliente.GetEmail(), senha, cliente.GetEndereco(),
                                   cliente.GetNumeroEndereco(), cliente.GetComplementoEndereco(), cliente.GetBairro(), cliente.GetCidade(),
                                   cliente.GetUF(), cliente.GetCEP(), cliente.GetTipoUsuario());
                MetodosBD.ExecutaSQL(SQL);
            }
        }
    }
}
