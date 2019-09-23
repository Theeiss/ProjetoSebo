using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using ProjetoSebo.views.telas_finais;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    public partial class TelaUsuariosCadastro : BaseParaTela<UsuarioController>
    {
        public TelaUsuariosCadastro(SeboContext context) : 
            base(context, new UsuarioController())
        {
            base.AtalhoTelaInclusao = this;
            base.AtalhoTelaConsulta = new TelaConsultaUsuarios(context);
            base.AtalhoTelaRelatorio = new TelaTipoProduto(context); //Tela apenas para teste
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Login = this.txtLogin.Text,
                Senha = this.txtSenha.Text,
            };

            ResultadoOperacao resultado = Controller.Gravar(usuario, this.imgFotoUsuario.Image);
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
            this.imgFotoUsuario.Image = Properties.Resources.foto_usuario;

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

        private void ImgFotoUsuario_Click(object sender, EventArgs e)
        {
            OpenFileDialog telaAbrir = new OpenFileDialog();
            telaAbrir.ShowDialog();

            if (string.IsNullOrEmpty(telaAbrir.FileName))
                return;

            this.imgFotoUsuario.Load(telaAbrir.FileName);
        }
    }
}
