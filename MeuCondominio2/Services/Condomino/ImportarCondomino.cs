using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MeuCondominio2.Model;
using System.Data;

namespace MeuCondominio2.Services.Condomino
{
    public class ImportarCondomino
    {
        public List<Model.Condomino> ImportarArquivoDeCondominosDoCondominio(StreamReader reader)
        {
            List<Model.Condomino> listaCondominos = new List<Model.Condomino>();

            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                string[] value = linha.Split(';');

                Model.Condomino condomino;

                condomino = new Model.Condomino();

                condomino.SetNome(value[0]);
                condomino.SetEmail(value[1]);
                condomino.SetTelefone(value[2]);
                condomino.SetEndereco(value[3]);
                condomino.SetNumeroEndereco(value[4]);
                condomino.SetComplementoEndereco(value[5]);
                condomino.SetBairro(value[6]);
                condomino.SetCidade(value[7]);
                condomino.SetCEP(value[8]);
                condomino.SetCPFCondomino1(value[9]);
                listaCondominos.Add(condomino);
            }
            return listaCondominos;
        }

        public DataTable ImportarArquivoDeCondominosDoCondominio(StreamReader reader, int qq)
        {
            DataTable dt = new DataTable();

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
