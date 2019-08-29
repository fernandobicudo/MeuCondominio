using System;

namespace MeuCondominio2
{
    public class Login
    {
        string email;
        string senha;

        public Login()
        {

        }

        public Login(string email, string senha)
        {
            this.email = email;
            this.SetSenha(senha);
        }

        public string GetSenha()
        {
            return senha;
        }

        public void SetSenha(string value)
        {
            senha = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }
    }
    //TODO: criar métodos do Login se necessário
    //TODO:   verificar se os atributos aqui devem fazer referência direta aos atributos da classe Usuario
}
