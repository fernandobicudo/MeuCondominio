using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCondominio2.Model
{
    public class Usuario
    {
        private int idUsuario;
        private string nome;
        private string email;
        private string telefone;
        private string senha;
        private string endereco;
        private string numeroEndereco;
        private string complementoEndereco;
        private string bairro;
        private string cidade;
        private string UF;
        private string CEP;
        private int tipoUsuario;

        public Usuario()
        {

        }

        public Usuario(int idUsuario, 
            string nome, 
            string email, 
            string telefone, 
            string senha, 
            string endereco, 
            string numeroEndereco, 
            string complementoEndereco, 
            string bairro, 
            string cidade, 
            string uF, 
            string cEP, 
            int tipoUsuario)
        {
            this.idUsuario = idUsuario;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.senha = senha;
            this.endereco = endereco;
            this.numeroEndereco = numeroEndereco;
            this.complementoEndereco = complementoEndereco;
            this.bairro = bairro;
            this.cidade = cidade;
            UF = uF;
            CEP = cEP;
            this.tipoUsuario = tipoUsuario;
        }

        public Usuario(
            string nome,
            string email,
            string telefone,
            string senha,
            string endereco,
            string numeroEndereco,
            string complementoEndereco,
            string bairro,
            string cidade,
            string uF,
            string cEP,
            int tipoUsuario)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.senha = senha;
            this.endereco = endereco;
            this.numeroEndereco = numeroEndereco;
            this.complementoEndereco = complementoEndereco;
            this.bairro = bairro;
            this.cidade = cidade;
            UF = uF;
            CEP = cEP;
            this.tipoUsuario = tipoUsuario;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string NumeroEndereco { get => numeroEndereco; set => numeroEndereco = value; }
        public string ComplementoEndereco { get => complementoEndereco; set => complementoEndereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string UF1 { get => UF; set => UF = value; }
        public string CEP1 { get => CEP; set => CEP = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
    //TODO: criar métodos da classe Usuario
}
