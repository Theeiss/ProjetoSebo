using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using ProjetoSebo.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.telas
{
    public partial class TelaLogin : Form
    {
        public UsuarioController UsuarioController { private get; set; }
        public TelaLogin(SeboContext context)
        {
            this.UsuarioController = new UsuarioController()
            {
                Context = context
            };

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlTitulo.ExibirBotoes(TituloPanel.Botoes.Fechar);
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            ResultadoOperacao resultado = ValidarCampos();
            if(resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            string login = this.txtLogin.Text;
            string senha = this.txtSenha.Text;

            resultado = this.UsuarioController.ValidarLogin(login, senha);
            if(resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            this.Hide();
            Limpar();
            new TelaPrincipal(this.UsuarioController.Context).ShowDialog();
            this.Show();
        }

        public ResultadoOperacao ValidarCampos()
        {
            if (this.txtLogin.TextLength == 0)
            {
                this.txtLogin.Focus();
                return new ResultadoAviso("O login deve ser informado.");
            }

            if (this.txtSenha.TextLength == 0)
            {
                this.txtSenha.Focus();
                return new ResultadoAviso("A senha deve ser informada.");
            }

            return new ResultadoSucesso();
        }

        public void Limpar()
        {
            this.txtLogin.Clear();
            this.txtSenha.Clear();

            this.txtLogin.Focus();
        }
    }
}
