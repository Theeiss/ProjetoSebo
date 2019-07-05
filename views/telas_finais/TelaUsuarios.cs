using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
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
            Usuario usuario = new Usuario()
            {
                Login = this.txtLogin.Text,
                Senha = this.txtSenha.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(usuario);
            if (resultado.VerificarSucessoOperacao())
            {
                Limpar();
            }

            resultado.Exibir();
        }

        private void Limpar()
        {
            this.txtLogin.Clear();
            this.txtSenha.Clear();
            this.txtConfirmarSenha.Clear();

            this.txtLogin.Focus();
        }

        public override void TratarConsistencia(ResultadoOperacao retorno)
        {
            switch(retorno.Campo)
            {
                case UsuarioController.CAMPO_LOGIN: this.txtLogin.Focus(); break;
                case UsuarioController.CAMPO_SENHA: this.txtSenha.Focus(); break;
                case UsuarioController.CAMPO_CONFIRMACAO_SENHA: this.txtConfirmarSenha.Focus(); break;
            }
        }

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
