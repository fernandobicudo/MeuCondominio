using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;
using MeuCondominio2.Services;
using System.Data;


namespace MeuCondominio2.DAO
{
    public class DAOUsuario
    {
        public static void InserirCliente(Cliente cliente)
        {
            string senha;
            GeradorDeSenhaProvisoria gerador = new GeradorDeSenhaProvisoria();
            if (cliente.GetSenha() == null)
                senha = gerador.GerarSenhaProvisoria();
            else
                senha = Criptografia.Encriptar(cliente.GetSenha());

            string SQL;
            SQL = String.Format(@"INSERT INTO `Usuario` (`nome`, `telefone`, `email`, `senha`, `endereco`, `numero_endereco`, " +
                               "`complementoEndereco`, `bairro`, `cidade`, `UF`, `CEP`, `idTipoUsuario`) VALUES " +
                               "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', {11});",
                               cliente.GetNome(), cliente.GetTelefone(), cliente.GetEmail(), senha, cliente.GetEndereco(),
                               cliente.GetNumeroEndereco(), cliente.GetComplementoEndereco(), cliente.GetBairro(), cliente.GetCidade(),
                               cliente.GetUF(), cliente.GetCEP(), cliente.GetTipoUsuario());

            MetodosBD.ExecutaSQL(SQL);

            Formatadores formatadores = new Formatadores();

            string CPFFormatado = formatadores.FormatarCPFSemPontosNemTracos(cliente.GetCPFCliente());

            SQL = String.Format(@"INSERT INTO `Cliente` (`idCliente`, `CPF`) VALUES (LAST_INSERT_ID(), '{0}'); ", CPFFormatado);
            MetodosBD.ExecutaSQL(SQL);
        }
    }
}
