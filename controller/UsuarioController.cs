using ProjetoSebo.dao;
using ProjetoSebo.model;
using System;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class UsuarioController : BaseParaController
    {
        private const int QTD_MINIMA_LOGIN = 5;
        private const int QTD_MINIMA_SENHA = 8;

        public ResultadoOperacao Gravar(Usuario usuario)
        {
            ResultadoOperacao resultado = ConsistirDados(usuario);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            Context.Usuarios.Add(usuario);
            Context.SaveChanges();

            return new ResultadoSucesso("Usuário cadastrado com sucesso.");
        }

        public ResultadoOperacao ValidarLogin(string login, string senha)
        {
            if (Context.Usuarios.Where(u => u.Login == login && u.Senha == senha).Count() == 0)
                return new ResultadoAviso("Usuário e/ou senha não encontrados.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirDados(Usuario usuario)
        {
            ResultadoOperacao resultado = ConsistirLogin(usuario.Login);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            resultado = ConsistirSenha(usuario.Senha);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            if (Context.Usuarios.Where(u => u.Login == usuario.Login).Count() > 0)
                return new ResultadoAviso("Este login já foi utilizado por outro usuário.");

            return new ResultadoSucesso();
        }

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
    }
}
