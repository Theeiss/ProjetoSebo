using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaProdutos : BaseParaTela<ProdutoController>
    {
        public TelaProdutos(SeboContext context) :
            base(context, new ProdutoController())
        {
            this.cbxTipo.SetContext(context);
        }

        private void BtnGravar_Click(object sender, System.EventArgs e)
        {
            Produto produto = new Produto()
            {
                Descricao = this.txtDescricao.Text,
                CodigoBarras = this.txtCodBarras.Text,
                Tipo = this.cbxTipo.TipoProdutoSelecionado,
                Preco = this.txtPreco.Valor,
                Quantidade = Convert.ToInt32(this.txtQuantidade.Valor),
                PalavrasChave = this.txtPalavrasChave.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(produto);
            if (resultado.VerificarSucessoOperacao())
                Limpar();

            resultado.Exibir();
        }

        public override void TratarConsistencia(ResultadoOperacao retorno)
        {
            switch(retorno.Campo)
            {
                case ProdutoController.CAMPO_DESCRICAO: this.txtDescricao.Focus(); break;
                case ProdutoController.CAMPO_CODIGO_BARRAS: this.txtCodBarras.Focus(); break;
                case ProdutoController.CAMPO_TIPO: this.cbxTipo.Focus(); break;
                case ProdutoController.CAMPO_PRECO: this.txtPreco.Focus(); break;
                case ProdutoController.CAMPO_QUANTIDADE: this.txtQuantidade.Focus(); break;
                case ProdutoController.CAMPO_LOCAL: this.cbxLocal.Focus(); break;
                case ProdutoController.CAMPO_PALAVRAS_CHAVE: this.txtPalavrasChave.Focus(); break;
            }
        }

        private void Limpar()
        {
            this.txtDescricao.Clear();
            this.txtCodBarras.Clear();
            this.txtPreco.Clear();
            this.txtQuantidade.Clear();
            this.txtPalavrasChave.Clear();

            this.txtDescricao.Focus();
        }

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
