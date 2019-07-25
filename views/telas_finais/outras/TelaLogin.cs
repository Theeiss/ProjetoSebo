using ProjetoSebo.bean;
using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.views;
using ProjetoSebo.views.components;
using System;

namespace ProjetoSebo.telas
{
    public partial class TelaLogin : BaseParaTela<LoginController>
    {
        public TelaLogin(SeboContext context) :
            base(context, new LoginController())
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlTitulo.ExibirBotoes(TituloPanel.Botoes.Fechar);
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login()
            {
                Usuario = this.txtLogin.Text,
                Senha = this.txtSenha.Text
            };

            ResultadoOperacao resultado = this.Controller.ConsistirAcesso(login);
            if(resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            this.Hide();
            Limpar();
            new TelaPrincipal(this.Controller.Context).ShowDialog();
            this.Show();
        }

        public override void TratarConsistencia(ResultadoOperacao retorno)
        {
            switch(retorno.Campo)
            {
                case LoginController.CAMPO_LOGIN: this.txtLogin.Focus(); break;
                case LoginController.CAMPO_SENHA: this.txtSenha.Focus(); break;
            }
        }

        public void Limpar()
        {
            this.txtLogin.Clear();
            this.txtSenha.Clear();

            this.txtLogin.Focus();
        }
    }
}
