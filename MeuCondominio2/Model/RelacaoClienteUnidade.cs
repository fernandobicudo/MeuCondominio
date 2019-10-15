using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class RelacaoClienteUnidade
    {
        private int idCliente;
        private int idUnidade;
        private bool ehMoradorDaUnidade;
        private bool ehProprietarioDaUnidade;

        public RelacaoClienteUnidade(int idCliente, int idUnidade, bool ehMoradorDaUnidade, bool ehProprietarioDaUnidade)
        {
            this.idCliente = idCliente;
            this.idUnidade = idUnidade;
            this.ehMoradorDaUnidade = ehMoradorDaUnidade;
            this.ehProprietarioDaUnidade = ehProprietarioDaUnidade;
        }

        public RelacaoClienteUnidade()
        {

        }

        public int GetIdCliente()
        {
            return idCliente;
        }

        public void SetIdCliente(int value)
        {
            idCliente = value;
        }

        public int GetIdUnidade()
        {
            return idUnidade;
        }

        public void SetIdUnidade(int value)
        {
            idUnidade = value;
        }

        public bool GetEhMoradorDaUnidade()
        {
            return ehMoradorDaUnidade;
        }

        public void SetEhMoradorDaUnidade(bool value)
        {
            ehMoradorDaUnidade = value;
        }

        public bool GetEhProprietarioDaUnidade()
        {
            return ehProprietarioDaUnidade;
        }

        public void SetEhProprietarioDaUnidade(bool value)
        {
            ehProprietarioDaUnidade = value;
        }
    }
}
