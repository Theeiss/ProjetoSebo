using ProjetoSebo.error;
using System;
using System.Linq;

namespace ProjetoSebo.validator
{
    public class UsuarioValidator
    {
        private const int QTD_MINIMA_LOGIN = 5;
        private const int QTD_MINIMA_SENHA = 8;

        public ResultadoOperacao ConsistirLogin(string login)
        {
            login = login.Trim();

            if (login.Length < QTD_MINIMA_LOGIN)
                return new ResultadoAviso(String.Format("O login deve possuir no mínimo {0} caracteres.", QTD_MINIMA_LOGIN));

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirSenha(string senha)
        {
            senha = senha.Trim();

            if (senha.Length < QTD_MINIMA_SENHA)
                return new ResultadoAviso(String.Format("A senha deve possuir no mínimo {0} caracteres.", QTD_MINIMA_SENHA));

            if (senha.Where(c => char.IsLetter(c)).Count() == 0)
                return new ResultadoAviso("A senha deve possuir pelo menos uma letra.");

            if (senha.Where(c => char.IsNumber(c)).Count() == 0)
                return new ResultadoAviso("A senha deve possuir pelo menos um número.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirConfirmacaoSenha(string senha, string confirmacao)
        {
            if (senha != confirmacao)
                return new ResultadoAviso("As senhas digitadas são diferentes.");

            return new ResultadoSucesso();
        }
    }
}
