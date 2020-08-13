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
        /*
                public int GetIdUsuario()
                {
                    return idUsuario;
                }

                public void SetIdUsuario(int value)
                {
                    idUsuario = value;
                }

                public string GetNome()
                {
                    return nome;
                }

                public void SetNome(string value)
                {
                    nome = value;
                }

                public string GetEmail()
                {
                    return email;
                }

                public void SetEmail(string value)
                {
                    email = value;
                }

                public string GetTelefone()
                {
                    return telefone;
                }

                public void SetTelefone(string value)
                {
                    telefone = value;
                }

                public string GetSenha()
                {
                    return senha;
                }

                public void SetSenha(string value)
                {
                    senha = value;
                }

                public string GetEndereco()
                {
                    return endereco;
                }

                public void SetEndereco(string value)
                {
                    endereco = value;
                }

                public string GetNumeroEndereco()
                {
                    return numeroEndereco;
                }

                public void SetNumeroEndereco(string value)
                {
                    numeroEndereco = value;
                }

                public string GetComplementoEndereco()
                {
                    return complementoEndereco;
                }

                public void SetComplementoEndereco(string value)
                {
                    complementoEndereco = value;
                }

                public string GetBairro()
                {
                    return bairro;
                }

                public void SetBairro(string value)
                {
                    bairro = value;
                }

                public string GetCidade()
                {
                    return cidade;
                }

                public void SetCidade(string value)
                {
                    cidade = value;
                }

                public string GetUF()
                {
                    return UF;
                }

                public void SetUF(string value)
                {
                    UF = value;
                }

                public string GetCEP()
                {
                    return CEP;
                }

                public void SetCEP(string value)
                {
                    CEP = value;
                }

                public int GetTipoUsuario()
                {
                    return tipoUsuario;
                }

                public void SetTipoUsuario(int value)
                {
                    tipoUsuario = value;
                }
                */
    }

    //TODO: criar métodos da classe Usuario
}
