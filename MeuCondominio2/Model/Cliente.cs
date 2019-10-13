using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class Cliente : Usuario
    {
        private string CPFCliente;

        public Cliente() 
        {

        }


        public Cliente(string CPFCliente)
        {
            this.CPFCliente = CPFCliente;

        }

        public string GetCPFCliente()
        {
            return CPFCliente;
        }

        public void SetCPFCliente(string value)
        {
            CPFCliente = value;
        }
    }
}
