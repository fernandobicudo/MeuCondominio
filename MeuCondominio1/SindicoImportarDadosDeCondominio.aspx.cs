using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Services.Condomino;
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
            ImportarCondomino importarCondomino = new ImportarCondomino();
            StreamReader reader = new StreamReader(@"c:\temp\" + nomeDoArquivo, System.Text.Encoding.Default);

            List<Condomino> listaCondominos = new List<Condomino>();



            dt = importarCondomino.LerArquivoDeCondominosDoCondominio(reader);

            gvDadosDosCondominos.DataSource = dt;
            gvDadosDosCondominos.DataBind();
            
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