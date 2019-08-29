using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    class Condomino : Usuario
    {
        string CPFCondomino;

        public Condomino()
        {
        }

        public Condomino(string cPFCondomino)
        {
            CPFCondomino = cPFCondomino;
        }

        public string CPFCondomino1 { get => CPFCondomino; set => CPFCondomino = value; }
    }
    //TODO: criar métodos da classe Condomino
}
