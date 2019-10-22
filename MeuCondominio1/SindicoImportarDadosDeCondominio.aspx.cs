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
using MeuCondominio2.Services.Unidade;

namespace MeuCondominio1
{
    public partial class SindicoImportarDadosDeCondominio : System.Web.UI.Page
    {
        static string nomeDoArquivo;
        static List<Cliente> listaClientesDaPlanilha;
        static StreamReader reader;
        //TODO: instanciadas variáveis estáticas para resolver o problema do carregamento da página com apagamento de dados. Buscar outra solução menos onerosa para a memória.

        protected void Page_Load(object sender, EventArgs e)
        {
/*            if (IsPostBack)
            {
                nomeDoArquivo = Session["nomeDoArquivo"].ToString();
            }*/
        }

        private void FazerUploadDoArquivoDaPlanilha()
        {
            if (fuArquivoDeImportacao.HasFile)
            {
                nomeDoArquivo = fuArquivoDeImportacao.FileName;
                Session["nomeDoArquivo"] = nomeDoArquivo; 
                fuArquivoDeImportacao.SaveAs(@"c:\temp\" + nomeDoArquivo);
            }

            ExibirDadosDeImportacaoDoArquivo();
        }

        private void ExibirDadosDeImportacaoDoArquivo()
        {
            ImportarClientes importarCliente = new ImportarClientes();
            LerDadosDaPlanilhaDeUsuarios();
            DataTable dt;
            dt = importarCliente.LerArquivoDeClientesDoCondominio(reader);
            gvDadosDosClientes.DataSource = dt;
            gvDadosDosClientes.DataBind();
            reader.Close();
            reader.Dispose();
            LerDadosDaPlanilhaDeUsuarios();
            CriarListaDeClientesNaMemoriaAPartirDaPlanilha(reader);
            
        }

        private void LerDadosDaPlanilhaDeUsuarios()
        {
            reader = new StreamReader(@"c:\temp\" + nomeDoArquivo, System.Text.Encoding.Default);
        }

        private static void CriarListaDeClientesNaMemoriaAPartirDaPlanilha(StreamReader reader)
        {
            ImportarClientes importarClientes = new ImportarClientes();
            listaClientesDaPlanilha = importarClientes.ImportarClientesDoArquivoDeClientesDoCondominio(reader);
            reader.Close();
            reader.Dispose();
        }

        private void ImportarDadosDosClientesParaBancoDeDados(List<Cliente> listaCliente)
        {
            GravaCliente.ImportarClientesDeLista(listaCliente);
        }

        protected void BtUpload_Click(object sender, EventArgs e)
        {
            FazerUploadDoArquivoDaPlanilha();
        }

        protected void BtImportarDados_Click(object sender, EventArgs e)
        {
            DataTable dt;
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);

            List<Cliente> listaClientesDoBancoDeDados = new List<Cliente>();
            Cliente ClienteDoBancoDeDados;

            //LER DADOS DA PLANILHA
            //listaClientesDaPlanilha = CriarListaDeClientesNaMemoriaAPartirDaPlanilha();

            //GRAVAR CLIENTES NO BANCO DE DADOS
            ImportarDadosDosClientesParaBancoDeDados(listaClientesDaPlanilha);

            foreach (Cliente cliente in listaClientesDaPlanilha)
            {
                ClienteDoBancoDeDados = new Cliente();
                dt = BuscaCliente.BuscarClientePorCPF(cliente.GetCPFCliente());
                ClienteDoBancoDeDados = ClienteDoBancoDeDados.ConstruirObjetoCliente(dt);
                listaClientesDoBancoDeDados.Add(ClienteDoBancoDeDados);
            }

            List<RelacaoClienteUnidade> ListaRelacaoClientesUnidades;
            ImportarClientes importarClientes = new ImportarClientes();
            List<ImportarClientes.DadosDaRelacaoDaPlanilha> ListaDadosDaRelacaoDaPlanilha;

            LerDadosDaPlanilhaDeUsuarios();
            ListaRelacaoClientesUnidades =
                importarClientes.CriarListaDeObjetosRelacaoClienteUnidadeDoCondominio
                (importarClientes.ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(reader));
            reader.Close();
            reader.Dispose();
            //TODO: a lista de relacao de clientes x unidades esta incluindo todoa da planilha, mas não deveria incluir aqueles que não foram inseridos na base por já estarem nela antes.

            LerDadosDaPlanilhaDeUsuarios();
            ListaDadosDaRelacaoDaPlanilha = importarClientes.ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(reader);
            reader.Close();
            reader.Dispose();

            Dictionary<string, RelacaoClienteUnidade> dict = ListaRelacaoClientesUnidades.ToDictionary(x => x.GetCPF1());

            foreach (Cliente cliente1 in listaClientesDoBancoDeDados)
            {
                if (dict.TryGetValue(cliente1.GetCPFCliente(), out RelacaoClienteUnidade encontrado)) encontrado.SetIdCliente(cliente1.GetIdUsuario());
            }

            foreach (ImportarClientes.DadosDaRelacaoDaPlanilha dados in ListaDadosDaRelacaoDaPlanilha)
            {
                int idUnidade;
                idUnidade = BuscaUnidade.BuscarUnidadePorDescricao(dados.unidade);

                if (dict.TryGetValue(dados.CPF, out RelacaoClienteUnidade encontrado)) encontrado.SetIdUnidade(idUnidade);
            }


            foreach (RelacaoClienteUnidade relacao in ListaRelacaoClientesUnidades)
            {
                GravaRelacaoClienteUnidade.GravarRelacaoClienteUnidade(relacao);
            }
        }
    }
}