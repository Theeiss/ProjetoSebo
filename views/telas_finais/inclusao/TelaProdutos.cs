using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using ProjetoSebo.views.telas_finais.consulta;
using System;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaProdutos : BaseParaTela<ProdutoController>
    {
        public TelaProdutos(SeboContext context) :
            base(context, new ProdutoController())
        {
            base.AtalhoTelaInclusao = this;
            base.AtalhoTelaConsulta = new TelaConsultaProdutos(Controller.Context);
            base.AtalhoTelaRelatorio = new TelaTipoProduto(Controller.Context); //Tela apenas para teste

            this.cbxTipo.SetContext(context);
            this.cbxLocal.SetContext(context);
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
                Local = this.cbxLocal.LocalProdutoSelecionado,
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

            this.cbxTipo.Limpar();
            this.cbxLocal.Limpar();

            this.txtDescricao.Focus();
        }

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
