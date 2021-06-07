using System;
using MeuCondominio2.Services;

namespace MeuCondominio2.Model
{
    public class Login
    {
        private string email;
        private string senha;

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = Criptografia.Encriptar(value); }

        public Login()
        {

        }

        public Login(string email, string senha)
        {
            this.email = email;
            this.Senha = senha;
        }
        #region antigos getters/setters
        /*
                public string GetSenha()
                {
                    return senha;
                }

                public void SetSenha(string value)
                {
                    senha = Criptografia.Encriptar(value);
                }

                public string GetEmail()
                {
                    return email;
                }

                public void SetEmail(string value)
                {
                    email = value;
                }

            */
        #endregion
    }
    //TODO: criar métodos do Login se necessário
    //TODO:   verificar se os atributos aqui devem fazer referência direta aos atributos da classe Usuario
}
