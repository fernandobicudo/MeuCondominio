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



        string nomeDoArquivo;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void FazerUploadDoArquivoDaPlanilha()
        {
            if (fuArquivoDeImportacao.HasFile)
            {
                nomeDoArquivo = fuArquivoDeImportacao.FileName;
                fuArquivoDeImportacao.SaveAs(@"c:\temp\" + nomeDoArquivo);
            }

            ExibirDadosDeImportacaoDoArquivo();
        }

        private void ExibirDadosDeImportacaoDoArquivo()
        {
            ImportarClientes importarCliente = new ImportarClientes();
            StreamReader reader = LerDadosDaPlanilhaDeUsuarios();
            DataTable dt;
            dt = importarCliente.LerArquivoDeClientesDoCondominio(reader);

            gvDadosDosClientes.DataSource = dt;
            gvDadosDosClientes.DataBind();
        }

        private StreamReader LerDadosDaPlanilhaDeUsuarios()
        {
            StreamReader reader = new StreamReader(@"c:\temp\" + nomeDoArquivo, System.Text.Encoding.Default);
            return reader;
        }


        private List<Cliente> CriarListaDeClientesNaMemoriaAPartirDaPlanilha()
        {
            ImportarClientes importarClientes = new ImportarClientes();
            List<Cliente> listaCliente;
            StreamReader reader = LerDadosDaPlanilhaDeUsuarios();
            listaCliente = importarClientes.ImportarClientesDoArquivoDeClientesDoCondominio(reader);
            return listaCliente;
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
            FazerUploadDoArquivoDaPlanilha();
            DataTable dt;
            int idCondominio = Convert.ToInt32(Session["codigoCondominio"]);

            List<Cliente> listaClientesDaPlanilha;
            List<Cliente> listaClientesDoBancoDeDados = new List<Cliente>();
            Cliente ClienteDoBancoDeDados;



            /*          ListaRelacaoClientesUnidades = importarClientes.ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(LerDadosDaPlanilhaDeUsuarios);*/

            //LER DADOS DA PLANILHA
            listaClientesDaPlanilha = CriarListaDeClientesNaMemoriaAPartirDaPlanilha();

            //GRAVAR CLIENTES NO BANCO DE DADOS
            ImportarDadosDosClientesParaBancoDeDados(listaClientesDaPlanilha);

            //RECUPERAR CLIENTES DO BANCO DE DADOS AGORA COM ID
            foreach (Cliente cliente in listaClientesDaPlanilha)
            {
                ClienteDoBancoDeDados = new Cliente();
                dt = BuscaCliente.BuscarClientePorCPF(cliente.GetCPFCliente());
                ClienteDoBancoDeDados = ClienteDoBancoDeDados.ConstruirObjetoCliente(dt);
                listaClientesDoBancoDeDados.Add(ClienteDoBancoDeDados);
            }

            //INSERIR CLIENTES NAS RELACOES CLIENTESxUNIDADES

            //A- buscar relacoes clientes x unidades da planilha
            List<RelacaoClienteUnidade> ListaRelacaoClientesUnidades;
            ImportarClientes importarClientes = new ImportarClientes();
            List<ImportarClientes.DadosDaRelacaoDaPlanilha> ListaDadosDaRelacaoDaPlanilha;


            ListaRelacaoClientesUnidades =
                importarClientes.CriarListaDeObjetosRelacaoClienteUnidadeDoCondominio
                (importarClientes.ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(LerDadosDaPlanilhaDeUsuarios()));

            ListaDadosDaRelacaoDaPlanilha = importarClientes.ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(LerDadosDaPlanilhaDeUsuarios());



            Dictionary<string, RelacaoClienteUnidade> dict = ListaRelacaoClientesUnidades.ToDictionary(x => x.GetCPF1());

            //B- percorrer relacoes x clientes na memória buscando id de cada unidade por descricao
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

            //C - percorrer lista de clientes vinda do banco na memória, gravando para cada unidade buscando cada CPF em cada para amarrar cada relacao cliente x unidade

            foreach(Cliente cliente2 in listaClientesDaPlanilha)
            {

            }

            //d- gravar no banco 1 relacao cliente x unidade para cada 

            foreach(RelacaoClienteUnidade relacao in ListaRelacaoClientesUnidades)
            {
                GravaRelacaoClienteUnidade.GravarRelacaoClienteUnidade(relacao);
            }





        }
       /* private void CriarRelacaoClienteUnidade(List<RelacaoClienteUnidade> listaRelacaoClienteUnidades)
        {
            List<ImportarClientes.DadosDaRelacaoDaPlanilha> dadosDaRelacaoDaPlanilha;
            ImportarClientes importarCliente = new ImportarClientes();

            dadosDaRelacaoDaPlanilha = importarCliente.ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(LerDadosDaPlanilhaDeUsuarios());

            foreach (RelacaoClienteUnidade linharelacao in listaRelacaoClienteUnidades)
            {
                int idUnidade;

                foreach (ImportarClientes.DadosDaRelacaoDaPlanilha dados in dadosDaRelacaoDaPlanilha)
                {
                    idUnidade = BuscaUnidade.BuscarUnidadePorDescricao(dados.unidade);


                }
            }
        }

        private List<Cliente> CriarListaDeClientes()
        {
            List<Cliente> listaCliente;
            ImportarClientes importarClientes = new ImportarClientes();
            List<RelacaoClienteUnidade> listaRelacaoClienteUnidades;

            List<ImportarClientes.DadosDaRelacaoDaPlanilha> dadosDaRelacaoDaPlanilha;

            listaCliente = CriarListaDeClientesNaMemoriaAPartirDaPlanilha();
            listaRelacaoClienteUnidades = new List<RelacaoClienteUnidade>();
            StreamReader reader = LerDadosDaPlanilhaDeUsuarios();
            dadosDaRelacaoDaPlanilha = importarClientes.ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(reader);
            RelacaoClienteUnidade relacao;

            foreach (Cliente cliente in listaCliente)
            {
                DataTable dt = new DataTable();
                string CPF = cliente.GetCPFCliente();
                dt = BuscaCliente.BuscarClientePorCPF(CPF);
                relacao = new RelacaoClienteUnidade();
                relacao.SetIdCliente(Convert.ToInt32(dt.Rows[0]["idCliente"]));
                listaRelacaoClienteUnidades.Add(relacao);
            }

            return listaCliente;

        }*/
    }
}