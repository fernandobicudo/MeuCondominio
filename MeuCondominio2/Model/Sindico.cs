using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    class Sindico : Usuario
    {
        int idSindico;
        string CPF;
        int idCondominio;

        public int IdSindico { get => idSindico; set => idSindico = value; }
        public string CPF1 { get => CPF; set => CPF = value; }
        public int IdCondominio { get => idCondominio; set => idCondominio = value; }

        public Sindico()
        {
        }

        public Sindico(int idSindico, string CPF, int idCondominio)
        {
            this.idSindico = idSindico;
            this.CPF = CPF;
            this.idCondominio = idCondominio;
        }

        public Sindico(string CPF, int idCondominio)
        {
            this.CPF = CPF;
            this.idCondominio = idCondominio;
        }

        #region antigos getters/setters
        /*public int GetIdSindico()
        {
            return idSindico;
        }

        public void SetIdSindico(int value)
        {
            idSindico = value;
        }

        public string GetCPF1()
        {
            return CPF;
        }

        public void SetCPF1(string value)
        {
            CPF = value;
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
    }
}
