using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MeuCondominio2.Model;
using System.Data;
using MeuCondominio2.Services.Condominio;
using MeuCondominio2.Services.Ferramentas;


namespace MeuCondominio2.Services.Cliente
{
    public class ImportarClientes
    {
        public ImportarClientes()
        {
        }

        public struct DadosDaRelacaoDaPlanilha
        {
            public string CPF;
            public string unidade;
            public string ehMorador;
            public string ehCondomino;
        }

        DataTable dt;
        DadosDaRelacaoDaPlanilha dadosDaRelacaoDaPlanilha;
        
        List<Model.Unidade> listaUnidades;
        Model.Condominio condominio = new Model.Condominio();
        List<Model.Cliente> listaClientes;
        List<Model.RelacaoClienteUnidade> listaRelacaoClienteUnidade;

        //TODO: o método de busca e construção de objeto Condominio deveria estar em qual classe?


            //DESCRICAO: MÉTODO PARA PEGAR UM OBJETO READER (CONTEÚDO LIDO DO CSV NA MEMÓRIA) E TRANSFORMÁ-LO NUMA LISTA DE OBJETOS DA CLASSE DE NEGÓCIO CLIENTE. 
        public List<Model.Cliente> ImportarClientesDoArquivoDeClientesDoCondominio(StreamReader reader)
        {
            listaClientes = new List<Model.Cliente>();
            Formatadores formatadores = new Formatadores();

            reader.ReadLine(); //descarta a primeira linha, que é o cabeçalho.

            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                string[] value = linha.Split(';');
                Model.Cliente cliente = new Model.Cliente
                {
                    Nome = value[0],
                    Email = value[1],
                    Telefone = value[2],
                    Endereco = value[3],
                    NumeroEndereco = value[4],
                    ComplementoEndereco = value[5],
                    Bairro = value[6],
                    Cidade = value[7],
                    UF1 = value[8],
                    CEP1 = value[9],
                    CPFCliente1 = formatadores.FormatarCPFSemPontosNemTracos(value[10]),
                    TipoUsuario = Convert.ToInt32(value[11])
                };
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

        //DESCRICAO: MÉTODO PARA PEGAR UM OBJETO READER (CONTEÚDO LIDO DO CSV NA MEMÓRIA) E TRANSFORMÁ-LO NUMA LISTA DE STRUCTS DO TIPO RELACAO CLIENTExUNIDADE. 
        public List<DadosDaRelacaoDaPlanilha> ImportarRelacaoClienteUnidadeDoCondominioDadosDaPlanilha(StreamReader reader)
        {
            List<DadosDaRelacaoDaPlanilha> listaDeDadosDaRelacaoDaPlanilha = new List<DadosDaRelacaoDaPlanilha>();
            Formatadores formatadores = new Formatadores();

            reader.ReadLine(); //descarta a primeira linha, que é o cabeçalho.

            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                string[] value = linha.Split(';');

                dadosDaRelacaoDaPlanilha = new DadosDaRelacaoDaPlanilha();

                dadosDaRelacaoDaPlanilha.CPF = formatadores.FormatarCPFSemPontosNemTracos(value[10]);
                dadosDaRelacaoDaPlanilha.unidade = value[12];
                dadosDaRelacaoDaPlanilha.ehMorador = value[13];
                dadosDaRelacaoDaPlanilha.ehCondomino = value[14];
                listaDeDadosDaRelacaoDaPlanilha.Add(dadosDaRelacaoDaPlanilha);
            }
            return listaDeDadosDaRelacaoDaPlanilha;
        }


        //METODO PARA PEGAR A LISTA CRIADA NO MÉTODO ANTERIOR E TRANSFORMA-LO NO OBJETO DA CLASSE DE NEGÓCIO RelacaoClienteUnidade
        public List<RelacaoClienteUnidade> CriarListaDeObjetosRelacaoClienteUnidadeDoCondominio(List<DadosDaRelacaoDaPlanilha> listaDeDadosDaRelacaoDaPlanilha)
        {
            RelacaoClienteUnidade relacaoClienteUnidade;
            List<RelacaoClienteUnidade> listaRelacaoClientesUnidades = new List<RelacaoClienteUnidade>();
            bool ehMorador;
            bool ehCondomino;

            foreach(DadosDaRelacaoDaPlanilha dadosDaRelacaoDaPlanilha in listaDeDadosDaRelacaoDaPlanilha)
            {
                if (dadosDaRelacaoDaPlanilha.ehMorador.ToUpper() == "Sim".ToUpper())
                    ehMorador = true;
                else
                    ehMorador = false;

                if (dadosDaRelacaoDaPlanilha.ehCondomino.ToUpper() == "Sim".ToUpper())
                    ehCondomino = true;
                else
                    ehCondomino = false;

                relacaoClienteUnidade = new RelacaoClienteUnidade(dadosDaRelacaoDaPlanilha.CPF, ehMorador, ehCondomino);
                listaRelacaoClientesUnidades.Add(relacaoClienteUnidade);
            }
            return listaRelacaoClientesUnidades;
        }


        public DataTable LerArquivoDeClientesDoCondominio(StreamReader reader)
        {
            dt = new DataTable();

            dt.Columns.Add("nome");
            dt.Columns.Add("email");
            dt.Columns.Add("telefone");
            dt.Columns.Add("endereco");
            dt.Columns.Add("numero");
            dt.Columns.Add("complemento");
            dt.Columns.Add("bairro");
            dt.Columns.Add("cidade");
            dt.Columns.Add("UF");
            dt.Columns.Add("CEP");
            dt.Columns.Add("CPF");
            dt.Columns.Add("Tipo de usuário");
            dt.Columns.Add("Unidade");
            dt.Columns.Add("É morador");
            dt.Columns.Add("É condômino");

            reader.ReadLine(); //descarta a primeira linha, que é o cabeçalho.

            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                string[] value = linha.Split(';');

                dt.NewRow();
                dt.Rows.Add(value);
            }
            reader.Close();
            reader.Dispose();
            return dt;
        }
        /*        public Model.Condominio BuscarDoCondominioDaSessao(int idCondominio)
                {
                    DataTable dtCondominio;

                    dtCondominio = BuscaCondominio.BuscarCondominioPorId(idCondominio);
                    Model.Condominio condominio = new Model.Condominio(Convert.ToInt32(dtCondominio.Rows[0]["id"]),
                        dtCondominio.Rows[0]["cnpj"].ToString(),
                        dtCondominio.Rows[0]["nome"].ToString(),
                        Convert.ToInt32(dtCondominio.Rows[0]["qtdVagasporUnidade"]));

                    return condominio;
                }


        */
    }
}
