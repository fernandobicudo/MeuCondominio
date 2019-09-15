using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class Eleicao
    {
        private int idEleicao;
        private string nomeEleicao;
        private string descricaoEleicao;
        private string statusEleicao; //TODO: na documentação está como boolean...
        private string tipoEleicao; //TODO: adicionar atributo tipoEleicao da classe Eleição à documentação
        private DateTime dataInicioEleicao;
        private DateTime dataFimEleicao;
        private int idCondominio;

        
        public Eleicao()
        {
        }

        public Eleicao(int idEleicao,
            string nomeEleicao,
            string descricaoEleicao,
            string tipoEleicao,
            string statusEleicao,
            DateTime dataInicioEleicao,
            DateTime dataFimEleicao,
            int idCondominio)
        {
            this.idEleicao = idEleicao;
            this.nomeEleicao = nomeEleicao;
            this.descricaoEleicao = descricaoEleicao;
            this.tipoEleicao = tipoEleicao;
            this.statusEleicao = statusEleicao;
            this.dataInicioEleicao = dataInicioEleicao;
            this.dataFimEleicao = dataFimEleicao;
            this.idCondominio = idCondominio;
        }

        public Eleicao(string nomeEleicao,
            string descricaoEleicao,
            string tipoEleicao,
            string statusEleicao,
            DateTime dataInicioEleicao,
            DateTime dataFimEleicao,
            int idCondominio)
        {
            this.nomeEleicao = nomeEleicao;
            this.descricaoEleicao = descricaoEleicao;
            this.tipoEleicao = tipoEleicao;
            this.statusEleicao = statusEleicao;
            this.dataInicioEleicao = dataInicioEleicao;
            this.dataFimEleicao = dataFimEleicao;
            this.idCondominio = idCondominio;
        }


        public int GetIdEleicao()
        {
            return idEleicao;
        }

        public void SetIdEleicao(int value)
        {
            idEleicao = value;
        }

        public string GetNomeEleicao()
        {
            return nomeEleicao;
        }

        public void SetNomeEleicao(string value)
        {
            nomeEleicao = value;
        }

        public string GetDescricaoEleicao()
        {
            return descricaoEleicao;
        }

        public void SetDescricaoEleicao(string value)
        {
            descricaoEleicao = value;
        }

        public string GetStatusEleicao()
        {
            return statusEleicao;
        }

        public void SetStatusEleicao(string value)
        {
            statusEleicao = value;
        }

        public string GetTipoEleicao()
        {
            return tipoEleicao;
        }

        public void SetTipoEleicao(string value)
        {
            tipoEleicao = value;
        }

        public DateTime GetDataInicioEleicao()
        {
            return dataInicioEleicao;
        }

        public void SetDataInicioEleicao(DateTime value)
        {
            dataInicioEleicao = value;
        }

        public DateTime GetDataFimEleicao()
        {
            return dataFimEleicao;
        }

        public void SetDataFimEleicao(DateTime value)
        {
            dataFimEleicao = value;
        }

        public int GetIdCondominio()
        {
            return idCondominio;
        }

        public void SetIdCondominio(int value)
        {
            idCondominio = value;
        }

        
    }
}
