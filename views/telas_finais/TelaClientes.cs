using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaClientes : BaseParaTela<ClienteController>
    {
        public TelaClientes(SeboContext context) :
            base(context, new ClienteController())
        {
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
                Sexo = ObterSexoInformado()
            };

            resultado = this.Controller.Gravar(cliente);
            if (resultado.VerificarSucessoOperacao())
            {
                Limpar();
            }

            resultado.Exibir();
        }

        private ResultadoOperacao ValidarCampos()
        {
            ResultadoOperacao resultado = this.Controller.ConsistirNome(this.txtNome.Text);
            if (resultado.VerificarFalhaOperacao())
            {
                this.txtNome.Focus();
                return resultado;
            }

            resultado = this.Controller.ConsistirCpf(this.txtCpf.Text);
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

            resultado = this.Controller.ConsistirSexo(ObterSexoInformado());
            if (resultado.VerificarFalhaOperacao())
            {
                this.rdbMasculino.Focus();
                return resultado;
            }

            return new ResultadoSucesso();
        }

        private Cliente.TipoSexo ObterSexoInformado()
        {
            if (this.rdbMasculino.Checked)
                return Cliente.TipoSexo.Masculino;
            else if (this.rdbFeminino.Checked)
                return Cliente.TipoSexo.Feminino;

            return Cliente.TipoSexo.Nenhum;
        }
        private void Limpar()
        {
            this.txtNome.Clear();
            this.txtCpf.Clear();
            this.txtDataNascimento.Clear();
            this.rdbMasculino.Checked = false;
            this.rdbFeminino.Checked = false;
        }

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
