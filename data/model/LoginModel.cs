using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class LoginModel : BaseParaModel
    {
        public LoginModel(Login login)
        {
            this.Usuario = login.Usuario;
            this.Senha = login.Senha;
        }

        public LoginModel()
        {

        }

        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
