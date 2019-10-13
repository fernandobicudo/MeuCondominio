using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MeuCondominio2.Model;
using System.Data;
using MeuCondominio2.Services.Condominio;


namespace MeuCondominio2.Services.Cliente
{
    public class ImportarClientes
    {
        DataTable dt;
        
        List<Model.Unidade> listaUnidades;
        Model.Condominio condominio = new Model.Condominio();
        List<Model.Cliente> listaClientes;

        //TODO: o método de busca e construção de objeto Condominio deveria estar em qual classe?
        //TODO: CRIAR CLASSE MORADOR
        

        public Model.Condominio BuscarDoCondominioDaSessao(int idCondominio)
        {
            DataTable dtCondominio;

            dtCondominio = BuscaCondominio.BuscarCondominioPorId(idCondominio);
            Model.Condominio condominio = new Model.Condominio(Convert.ToInt32(dtCondominio.Rows[0]["id"]),
                dtCondominio.Rows[0]["cnpj"].ToString(),
                dtCondominio.Rows[0]["nome"].ToString(),
                Convert.ToInt32(dtCondominio.Rows[0]["qtdVagasporUnidade"]));

            return condominio;
        }

        public List<Model.Cliente> ImportarConddominosDoArquivoDeClientesDoCondominio(StreamReader reader)
        {
            
            listaClientes = new List<Model.Cliente>();
            listaUnidades = new List<Model.Unidade>();
            


            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                string[] value = linha.Split(';');

                Model.Cliente cliente = new Model.Cliente();
                Model.Unidade unidade; 

                cliente.SetNome(value[0]);
                cliente.SetEmail(value[1]);
                cliente.SetTelefone(value[2]);
                cliente.SetEndereco(value[3]);
                cliente.SetNumeroEndereco(value[4]);
                cliente.SetComplementoEndereco(value[5]);
                cliente.SetBairro(value[6]);
                cliente.SetCidade(value[7]);
                cliente.SetCEP(value[8]);
                cliente.SetCPFCliente(value[9]);
                cliente.SetTipoUsuario(Convert.ToInt32(value[10]));
                listaClientes.Add(cliente);

            }
            return listaClientes;

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
            dt.Columns.Add("CEP");
            dt.Columns.Add("CPF");
            dt.Columns.Add("unidade");

            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                string[] value = linha.Split(';');

                dt.NewRow();
                dt.Rows.Add(value);
            }
            return dt;
        }


    }
}
