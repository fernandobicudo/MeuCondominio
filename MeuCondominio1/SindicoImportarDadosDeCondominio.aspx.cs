using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services.Cliente;
using MeuCondominio2.Model;
using System.Data;

namespace MeuCondominio1
{
    public partial class SindicoImportarDadosDeCondominio : System.Web.UI.Page
    {

        string nomeDoArquivo;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btPreview_Click(object sender, EventArgs e)
        {
            ExibirDadosDeImportacaoDoArquivo();
        }

        private void ExibirDadosDeImportacaoDoArquivo()
        {
            ImportarClientes importarCliente = new ImportarClientes();
            StreamReader reader = new StreamReader(@"c:\temp\" + nomeDoArquivo, System.Text.Encoding.Default);

            List<Cliente> listaCliente = new List<Cliente>();

            dt = importarCliente.LerArquivoDeClientesDoCondominio(reader);
            
            gvDadosDosClientes.DataSource = dt;
            gvDadosDosClientes.DataBind();
        }

        protected void btUpload_Click(object sender, EventArgs e)
        {
            if (fuArquivoDeImportacao.HasFile)
            {
                nomeDoArquivo = fuArquivoDeImportacao.FileName;
                fuArquivoDeImportacao.SaveAs(@"c:\temp\" + nomeDoArquivo);

                ExibirDadosDeImportacaoDoArquivo();
            }
        }

        protected void btImportarDados_Click(object sender, EventArgs e)
        {

        }
    }
}