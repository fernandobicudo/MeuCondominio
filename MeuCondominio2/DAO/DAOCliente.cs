using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;


namespace MeuCondominio2.DAO
{
    public class DAOCliente
    {
        public static void InserirClientesEmLote(List<Cliente> listaDeClientes)
        {
            foreach (Cliente cliente in listaDeClientes)
            {
                DAOUsuario.InserirCliente(cliente);
            }
        }

        internal static DataTable PesquisarClientePorCPF(string CPF)
        {

            Formatadores formatadores = new Formatadores();

            string CPFFormatado = formatadores.FormatarCPFSemPontosNemTracos(CPF);
            DataTable dt;
            string SQL;
            SQL = String.Format(@"SELECT * FROM `Usuario` us " +
                " JOIN Cliente cl ON cl.idCliente = us.idUsuario " +
                "WHERE cl.CPF = '{0}';", CPFFormatado);
            dt = MetodosBD.ExecutaSelect(SQL);

            return dt;
        }
    }
}
