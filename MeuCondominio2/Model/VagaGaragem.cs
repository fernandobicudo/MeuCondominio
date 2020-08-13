using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class VagaGaragem
    {
        private int idVaga;
        private int numeracao;
        private bool vagaSequencial;

        public int IdVaga { get => idVaga; set => idVaga = value; }
        public int Numeracao { get => numeracao; set => numeracao = value; }
        public bool VagaSequencial { get => vagaSequencial; set => vagaSequencial = value; }

        public VagaGaragem()
        {

        }

        public VagaGaragem(int idVaga, int numeracao, bool vagaSequencial)
        {
            this.idVaga = idVaga;
            this.numeracao = numeracao;
            this.vagaSequencial = vagaSequencial;
        }

    }


    //TODO: criar métodos da classe VagasGaragem
}
#region antigos getters/setters
/*        public int GetIdVaga()
        {
            return idVaga;
        }

        public void SetIdVaga(int value)
        {
            idVaga = value;
        }

        public int GetNumeracao()
        {
            return Numeracao;
        }

        public void SetNumeracao(int value)
        {
            Numeracao = value;
        }

        public bool GetVagaSequencial()
        {
            return vagaSequencial;
        }

        public void SetVagaSequencial(bool value)
        {
            vagaSequencial = value;
        }
*/
#endregion