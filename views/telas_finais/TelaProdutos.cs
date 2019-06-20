using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaProdutos : Form
    {
        public ProdutoController ProdCtrl { private get; set; }

        public TelaProdutos(SeboContext context)
        {
            this.ProdCtrl = new ProdutoController()
            {
                Context = context
            };

            InitializeComponent();

            this.cbxTipo.SetContext(context);
        }

        private void BtnGravar_Click(object sender, System.EventArgs e)
        {
            ResultadoOperacao resultado = ValidarCampos();
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            Produto produto = new Produto()
            {
                Descricao = this.txtDescricao.Text,
                CodigoBarras = Convert.ToInt32(this.txtCodBarras.Text),
                Preco = Convert.ToDouble(this.txtPreco.Text),
                Quantidade = Convert.ToInt32(this.txtQuantidade),
                PalavrasChave = this.txtPalavrasChave.Text
            };

            resultado = ProdCtrl.Gravar(produto);

            if (resultado.VerificarSucessoOperacao())
            {
                Limpar();
            }

            resultado.Exibir();
        }

        private ResultadoOperacao ValidarCampos()
        {
            return new ResultadoSucesso();
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
    }
}
