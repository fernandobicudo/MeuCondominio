using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    class VagaGaragem
    {
        int idVaga;
        int numeracao; //TODO: ajustar tipo do atributo nos diagramas de classe
        bool vagaSequencial;

        public VagaGaragem()
        {

        }

        public VagaGaragem(int idVaga, int numeracao, bool vagaSequencial)
        {
            this.idVaga = idVaga;
            this.numeracao = numeracao;
            this.SetVagaSequencial(vagaSequencial);
        }

        public int GetIdVaga()
        {
            return idVaga;
        }

        public void SetIdVaga(int value)
        {
            idVaga = value;
        }

        public int GetNumeracao()
        {
            return numeracao;
        }

        public void SetNumeracao(int value)
        {
            numeracao = value;
        }

        public bool GetVagaSequencial()
        {
            return vagaSequencial;
        }

        public void SetVagaSequencial(bool value)
        {
            vagaSequencial = value;
        }
    }


    //TODO: criar métodos da classe VagasGaragem
}
