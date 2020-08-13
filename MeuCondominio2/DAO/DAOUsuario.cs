using System;
using System.Collections.Generic;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;
using MeuCondominio2.Services;
using System.Data;
using MySql.Data.MySqlClient;


namespace MeuCondominio2.DAO
{
    public class DAOUsuario
    {
        public static void InserirCliente(Cliente cliente)
        {
            string senha;
            Formatadores formatadores = new Formatadores();
            string CPFFormatado = formatadores.FormatarCPFSemPontosNemTracos(cliente.CPFCliente1);
            GeradorDeSenhaProvisoria gerador = new GeradorDeSenhaProvisoria();

            if (cliente.Senha == null)
            {
                senha = MeuCondominio2.Properties.Settings.Default.senhaUsuarios;
                senha = Criptografia.Encriptar(senha); //TODO: utilizar gerador.GerarSenhaProvisoria();
            }

            else
                senha = Criptografia.Encriptar(cliente.Senha);

            string SQL;
            SQL = String.Format(@"INSERT INTO `Usuario` (`nome`, `telefone`, `email`, `senha`, `endereco`, `numero_endereco`, " +
                               "`complementoEndereco`, `bairro`, `cidade`, `UF`, `CEP`, `idTipoUsuario`) VALUES " +
                               "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', {11});",
                               cliente.Nome, cliente.Telefone, cliente.Email, senha, cliente.Endereco,
                               cliente.NumeroEndereco, cliente.ComplementoEndereco, cliente.Bairro, cliente.Cidade,
                               cliente.UF1, cliente.CEP1, cliente.TipoUsuario);

            try
            {
                MetodosBD.ExecutaSQL(SQL);
                SQL = String.Format(@"INSERT INTO `Cliente` (`idCliente`, `CPF`) VALUES (LAST_INSERT_ID(), '{0}'); ", CPFFormatado);
                MetodosBD.ExecutaSQL(SQL);

            }
            catch (MySqlException erro)
            {
                if (erro.Number == 1062)
                {
                    
                }

            }
        }
    }
}
