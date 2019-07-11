using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class UsuarioModel : BaseParaModel
    {
        public UsuarioModel(Usuario usuario)
        {
            this.Id = usuario.Id;
            this.Login = usuario.Login;
            this.Senha = usuario.Senha;
        }

        public UsuarioModel()
        {

        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
