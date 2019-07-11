using ProjetoSebo.bean;
using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.data.shared;
using ProjetoSebo.error;
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
            Cliente cliente = new Cliente()
            {
                Nome = this.txtNome.Text,
                Cpf = this.txtCpf.Text,
                DataNascimento = this.txtDataNascimento.DataHora,
                Sexo = ObterSexoInformado(),
                Telefone = this.txtTelefone.Text,
                Email = this.txtEmail.Text
            };

            ResultadoOperacao resultado = this.Controller.Gravar(cliente);
            if (resultado.VerificarSucessoOperacao())
            {
                Limpar();
            }

            resultado.Exibir();
        }

        private TipoSexo ObterSexoInformado()
        {
            if (this.rdbMasculino.Checked)
                return TipoSexo.Masculino;
            else if (this.rdbFeminino.Checked)
                return TipoSexo.Feminino;

            return TipoSexo.Nenhum;
        }
        private void Limpar()
        {
            this.txtNome.Clear();
            this.txtCpf.Clear();
            this.txtDataNascimento.Clear();
            this.rdbMasculino.Checked = false;
            this.rdbFeminino.Checked = false;
            this.txtTelefone.Clear();
            this.txtEmail.Clear();
        }

        public override void TratarConsistencia(ResultadoOperacao retorno)
        {
            switch(retorno.Campo)
            {
                case ClienteController.CAMPO_NOME: this.txtNome.Focus(); break;
                case ClienteController.CAMPO_DATA_NASCIMENTO: this.txtDataNascimento.Focus(); break;
                case ClienteController.CAMPO_CPF: this.txtCpf.Focus(); break;
                case ClienteController.CAMPO_SEXO: break;
                case ClienteController.CAMPO_TELEFONE: this.txtTelefone.Focus(); break;
                case ClienteController.CAMPO_EMAIL: this.txtEmail.Focus(); break;
            }
        }
        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
