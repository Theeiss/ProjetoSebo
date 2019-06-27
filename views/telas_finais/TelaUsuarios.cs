using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;

namespace ProjetoSebo.views
{
    public partial class TelaUsuariosCadastro : BaseParaTela<UsuarioController>
    {
        public TelaUsuariosCadastro(SeboContext context) :
            base(context, new UsuarioController())
        {
        }

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            ResultadoOperacao resultado = ValidarCampos();
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            Usuario usuario = new Usuario()
            {
                Login = this.txtLogin.Text,
                Senha = this.txtSenha.Text
            };

            resultado = Controller.Gravar(usuario);

            if (resultado.VerificarSucessoOperacao())
            {
                Limpar();
            }

            resultado.Exibir();
        }

        private ResultadoOperacao ValidarCampos()
        {
            string login = this.txtLogin.Text;
            if (login.Length == 0)
            {
                this.txtLogin.Focus();
                return new ResultadoAviso("O login deve ser informado.");
            }

            ResultadoOperacao resultado = Controller.ConsistirLogin(login);
            if (resultado.VerificarFalhaOperacao())
            {
                this.txtLogin.Focus();
                return resultado;
            }

            string senha = this.txtSenha.Text;
            if (senha.Length == 0)
            {
                this.txtSenha.Focus();
                return new ResultadoAviso("A senha deve ser informada.");
            }

            resultado = Controller.ConsistirSenha(senha);
            if (resultado.VerificarFalhaOperacao())
            {
                this.txtSenha.Focus();
                return resultado;
            }

            if (this.txtConfirmarSenha.TextLength == 0)
            {
                this.txtConfirmarSenha.Focus();
                return new ResultadoAviso("É necessário confirmar a senha.");
            }

            if (this.txtConfirmarSenha.Text != senha)
            {
                this.txtConfirmarSenha.Focus();
                return new ResultadoAviso("As senhas digitadas são diferentes.");
            }

            return new ResultadoSucesso();
        }
        private void Limpar()
        {
            this.txtLogin.Clear();
            this.txtSenha.Clear();
            this.txtConfirmarSenha.Clear();

            this.txtLogin.Focus();
        }
    }
}
