using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class VagaGaragem
    {
        private int idVaga;
        private int numeracao; //TODO: ajustar tipo do atributo nos diagramas de classe
        private bool vagaSequencial;
        //TODO: incluir idCondominio, e substituir idUnidade por idCondominio no banco.
        //TODO: atualizar Diagrama de Classes de Negócio e Modelo Lógico

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
