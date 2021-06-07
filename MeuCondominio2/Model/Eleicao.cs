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
        private bool statusEleicao; //TODO: na documentação está como boolean...
        private string tipoEleicao; //TODO: adicionar atributo tipoEleicao da classe Eleição à documentação
        private DateTime dataInicioEleicao;
        private DateTime dataFimEleicao;
        private int idCondominio;

        public int IdEleicao { get => idEleicao; set => idEleicao = value; }
        public string NomeEleicao { get => nomeEleicao; set => nomeEleicao = value; }
        public string DescricaoEleicao { get => descricaoEleicao; set => descricaoEleicao = value; }
        public bool StatusEleicao { get => statusEleicao; set => statusEleicao = value; }
        public string TipoEleicao { get => tipoEleicao; set => tipoEleicao = value; }
        public DateTime DataInicioEleicao { get => dataInicioEleicao; set => dataInicioEleicao = value; }
        public DateTime DataFimEleicao { get => dataFimEleicao; set => dataFimEleicao = value; }
        public int IdCondominio { get => idCondominio; set => idCondominio = value; }

        public Eleicao()
        {
        }

        public Eleicao(int idEleicao,
            string nomeEleicao,
            string descricaoEleicao,
            string tipoEleicao,
            bool statusEleicao,
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
            bool statusEleicao,
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


    }
}
#region antigos getters/setters
/*
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

        public bool  GetStatusEleicao()
        {
            return statusEleicao;
        }

        public void SetStatusEleicao(bool value)
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
*/
#endregion