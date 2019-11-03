using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services.Cliente;
using MeuCondominio2.Model;
using MeuCondominio2.Services.Ferramentas;

namespace MeuCondominio1
{
    public partial class ClienteCadastro : System.Web.UI.Page
    {
        DataTable dt;
        Cliente cliente; 

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridViewComDadosDoCliente();
            cliente = ConstruirObjetoCliente(dt);
            CarregarCamposDoCliente(cliente);
            
        }

        private void CarregarGridViewComDadosDoCliente()
        {
            int idCliente = Convert.ToInt32(Session["codigoUser"]);
            BuscaCliente buscaCliente = new BuscaCliente();
            dt = buscaCliente.BuscarClientePorIDRetornandoSuasUnidadesECondominios(idCliente);

            gvUnidadesDoCliente.DataSource = dt;
            gvUnidadesDoCliente.DataBind();

        }

        private void CarregarCamposDoCliente(Cliente cliente)
        {
            txNomeCliente.Text = cliente.GetNome();
            txCPF.Text = cliente.GetCPFCliente();
            txEmail.Text = cliente.GetEmail();
            txLogradouro.Text = cliente.GetEndereco();
            txNumeroLogradouro.Text = cliente.GetNumeroEndereco();
            txComplemento.Text = cliente.GetComplementoEndereco();
            txBairro.Text = cliente.GetBairro();
            txCidade.Text = cliente.GetCidade();
            txEstado.Text = cliente.GetUF();
            txCEP.Text = cliente.GetCEP();
        }

        private Cliente ConstruirObjetoCliente (DataTable dt)
        {
            Cliente cliente = new Cliente(Convert.ToInt32(dt.Rows[0]["idCliente"]),
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

        protected void Bt_AlterarSenha(object sender, EventArgs e)
        {
            Response.Redirect("AlteracaoDeSenha.aspx?&origem=logado");
        }
    }
}