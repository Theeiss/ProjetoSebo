using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class UsuarioController : BaseParaController
    {
        public const int CAMPO_LOGIN = 1;
        public const int CAMPO_SENHA = 2;
        public const int CAMPO_CONFIRMACAO_SENHA = 3;

        public UsuarioValidator Validator { get; set; }

        public UsuarioController()
        {
            Validator = new UsuarioValidator();
        }

        public ResultadoOperacao Gravar(Usuario usuario)
        {
            ResultadoOperacao resultado = ConsistirDados(usuario);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            Context.Usuarios.Add(usuario);
            Context.SaveChanges();

            return new ResultadoSucesso("Usuário cadastrado com sucesso.");
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            Usuario usuario = dados as Usuario;

            ResultadoOperacao resultado = this.Validator.ConsistirLogin(usuario.Login);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_LOGIN;
                return resultado;
            }

            resultado = this.Validator.ConsistirSenha(usuario.Senha);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_SENHA;
                return resultado;
            }

            if (Context.Usuarios.Where(u => u.Login == usuario.Login).Count() > 0)
                return new ResultadoAviso("Este login já foi utilizado por outro usuário.");

            return new ResultadoSucesso();
        }        
    }
}
