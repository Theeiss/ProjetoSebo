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
            ResultadoOperacao resultado = Controller.ConsistirLogin(this.txtLogin.Text);
            if (resultado.VerificarFalhaOperacao())
            {
                this.txtLogin.Focus();
                return resultado;
            }

            resultado = Controller.ConsistirSenha(this.txtSenha.Text);
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

            resultado = Controller.ConsistirConfirmacaoSenha(this.txtSenha.Text, this.txtConfirmarSenha.Text);
            if (resultado.VerificarFalhaOperacao())
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

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
