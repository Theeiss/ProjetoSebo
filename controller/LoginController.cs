using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class LoginController : BaseParaController
    {
        public const int CAMPO_LOGIN = 1;
        public const int CAMPO_SENHA = 2;

        public UsuarioValidator Validator { get; set; }

        public ResultadoOperacao ConsistirAcesso(Login login)
        {
            ResultadoOperacao resultado = ConsistirDados(login);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            if (Context.Usuarios.Where(u => u.Login == login.Usuario && u.Senha == login.Senha).Count() == 0)
                return new ResultadoAviso("Usuário e/ou senha não encontrados.", CAMPO_LOGIN);

            return new ResultadoSucesso();
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            //Login login = dados as Login;

            return new ResultadoSucesso();
        }
    }
}
