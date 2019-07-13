using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class LoginModel : BaseParaModel
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public LoginModel()
        {
        }

        public LoginModel(Login login)
        {
            this.Usuario = login.Usuario;
            this.Senha = login.Senha;
        }
    }
}
