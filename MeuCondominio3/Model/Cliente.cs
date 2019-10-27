using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MeuCondominio2.Model
{
    public class Cliente : Usuario
    {
        private string CPFCliente;


        public Cliente() : base()
        {

        }

        public Cliente(int idUsuario, string nome, string email, string telefone, string senha, string endereco, string numeroEndereco, string complementoEndereco, string bairro, string cidade, string UF, string cEP, int tipoUsuario, string CPFCliente)
            : base(idUsuario, nome, email, telefone, senha, endereco, numeroEndereco, complementoEndereco, bairro, cidade, UF, cEP, tipoUsuario)
        {
            this.CPFCliente = CPFCliente;
        }

        public string GetCPFCliente()
        {
            return CPFCliente;
        }

        public void SetCPFCliente(string value)
        {
            CPFCliente = value;
        }


        public Cliente ConstruirObjetoCliente(DataTable dt)
        {
            Cliente cliente = new Cliente(
                Convert.ToInt32(dt.Rows[0]["idUsuario"]),
                dt.Rows[0]["nome"].ToString(),
                dt.Rows[0]["email"].ToString(),
                dt.Rows[0]["telefone"].ToString(),
                dt.Rows[0]["senha"].ToString(),
                dt.Rows[0]["endereco"].ToString(),
                dt.Rows[0]["numero_endereco"].ToString(),
                dt.Rows[0]["complementoEndereco"].ToString(),
                dt.Rows[0]["bairro"].ToString(),
                dt.Rows[0]["cidade"].ToString(),
                dt.Rows[0]["UF"].ToString(),
                dt.Rows[0]["CEP"].ToString(),
                Convert.ToInt32(dt.Rows[0]["idTipoUsuario"]),
                dt.Rows[0]["CPF"].ToString());

            return cliente;
        }
    }
}
