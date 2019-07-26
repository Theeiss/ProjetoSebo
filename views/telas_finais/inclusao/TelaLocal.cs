using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaLocal : BaseParaTela<LocalProdutoController>
    {
        public TelaLocal(SeboContext context) :
            base(context, new LocalProdutoController())
        {
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            LocalProduto local = new LocalProduto()
            {
                Descricao = this.txtDescricao.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(local);
            if (resultado.VerificarSucessoOperacao())
                Limpar();

            resultado.Exibir();
        }

        public override void TratarConsistencia(ResultadoOperacao retorno)
        {
            switch (retorno.Campo)
            {
                case LocalProdutoController.CAMPO_DESCRICAO: this.txtDescricao.Focus(); break;
            }
        }

        private void Limpar()
        {
            this.txtDescricao.Clear();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
