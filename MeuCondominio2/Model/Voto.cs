using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class Voto
    {
        private int idVoto;
        private int idOpcaoVotada;
        private int idEleicao;
        private int idUnidade;

        public int IdVoto { get => idVoto; set => idVoto = value; }
        public int IdOpcaoVotada { get => idOpcaoVotada; set => idOpcaoVotada = value; }
        public int IdEleicao { get => idEleicao; set => idEleicao = value; }
        public int IdUnidade { get => idUnidade; set => idUnidade = value; }

        public Voto()
        {
        }

        public Voto(int idVoto, int idOpcaoVotada, int idEleicao, int idUnidade)
        {
            this.idVoto = idVoto;
            this.idOpcaoVotada = idOpcaoVotada;
            this.idEleicao = idEleicao;
            this.idUnidade = idUnidade;
        }

        public Voto(int idOpcaoVotada, int idEleicao, int idUnidade)
        {
            this.idOpcaoVotada = idOpcaoVotada;
            this.idEleicao = idEleicao;
            this.idUnidade = idUnidade;
        }

    }
}

#region antigos getters/setters
/*        public int GetIdVoto()
        {
            return idVoto;
        }

        public void SetIdVoto(int value)
        {
            idVoto = value;
        }

        public int GetIdOpcaoVotada()
        {
            return idOpcaoVotada;
        }

        public void SetIdOpcaoVotada(int value)
        {
            idOpcaoVotada = value;
        }

        public int GetIdEleicao()
        {
            return idEleicao;
        }

        public void SetIdEleicao(int value)
        {
            idEleicao = value;
        }

        public int GetIdUnidade()
        {
            return idUnidade;
        }

        public void SetIdUnidade(int value)
        {
            idUnidade = value;
        }
*/
#endregion