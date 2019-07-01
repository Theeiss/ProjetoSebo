using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaClientes : Form
    {
        ClienteController ClienteController { get; set; }

        public TelaClientes(SeboContext context)
        {
            this.ClienteController = new ClienteController
            {
                Context = context
            };

            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            ResultadoOperacao resultado = ValidarCampos();
            if(resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            Cliente cliente = new Cliente()
            {
                Nome = this.txtNome.Text,
                Cpf = this.txtCpf.Text,
                DataNascimento = Convert.ToDateTime(this.txtDataNascimento.Text),
                Sexo = this.rdbMasculino.Checked ? Cliente.TipoSexo.Masculino : Cliente.TipoSexo.Feminino
            };

            resultado = this.ClienteController.Gravar(cliente);
            if (resultado.VerificarSucessoOperacao())
            {
                Limpar();
            }

            resultado.Exibir();
        }

        private ResultadoOperacao ValidarCampos()
        {
            if(this.txtNome.TextLength == 0)
            {
                this.txtNome.Focus();
                return new ResultadoAviso("Nome do cliente deve ser informado.");
            }

            string cpf = this.txtCpf.Text;
            if (cpf.Length == 0)
            {
                this.txtCpf.Focus();
                return new ResultadoAviso("CPF do cliente deve ser informado.");
            }

            ResultadoOperacao resultado = this.ClienteController.ConsistirCpf(cpf);
            if(resultado.VerificarFalhaOperacao())
            {
                this.txtCpf.Focus();
                return resultado;
            }

            if(txtDataNascimento.TextLength == 0)
            {
                this.txtDataNascimento.Focus();
                return new ResultadoAviso("Data de nascimento deve ser informada.");
            }

            return new ResultadoSucesso();
        }

        private void Limpar()
        {
            this.txtNome.Clear();
            this.txtCpf.Clear();
            this.txtDataNascimento.Clear();
            this.rdbMasculino.Checked = false;
            this.rdbFeminino.Checked = false;
        }
    }
}
