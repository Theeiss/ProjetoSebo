using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaTipoProduto: BaseParaTela<TipoProdutoController>
    {
        public TelaTipoProduto(SeboContext context) : 
            base(context, new TipoProdutoController())
        {
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            TipoProduto tipoProduto = new TipoProduto()
            {
                Descricao = this.txtDescricao.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(tipoProduto);
            if (resultado.VerificarSucessoOperacao())
                Limpar();

            resultado.Exibir();
        }

        public override void TratarConsistencia(ResultadoOperacao retorno)
        {
            switch (retorno.Campo)
            {
                case TipoProdutoController.CAMPO_DESCRICAO: this.txtDescricao.Focus(); break;
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
