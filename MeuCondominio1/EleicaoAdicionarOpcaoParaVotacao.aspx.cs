using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MeuCondominio2.Model;

namespace MeuCondominio1
{
    public partial class EleicaoAdicionarOpcaoParaVotacao : System.Web.UI.Page
    {
        public string OpcaoDeVotacaoPlebiscito; 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["RefUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void CriarObjeto(object sender, EventArgs e)
        {
            string descricao = txDescricaoOpcao.Text;
            Response.Redirect("CadastroEleicao.aspx?descricao=" + descricao);
        }

        protected void BtVoltarClick(object sender, EventArgs e)
        {
            object refUrl = ViewState["RefUrl"];
            if (refUrl != null)
                Response.Redirect((string)refUrl);
        }
    }
}