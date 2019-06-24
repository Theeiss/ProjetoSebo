using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaVendas : Form
    {
        public VendasController VendasCtrl { private get; set; }
        public List<ItemVenda> Itens { get; set; }

        public TelaVendas(SeboContext context)
        {
            this.VendasCtrl = new VendasController()
            {
                Context = context
            };

            Itens = new List<ItemVenda>();

            InitializeComponent();

            this.cbxTipo.SetContext(context);
        }

        private void BtnAdicionar_Click(object sender, System.EventArgs e)
        {
            Produto produtoTmp = new Produto()
            {
                Descricao = "Borracha",
                Local = null,
                Preco = 12,
                Quantidade = 1,
                Tipo = new TipoProduto(),
                CodigoBarras = 1111,
                PalavrasChave = "borracha"
            };

            ItemVenda itemVendaTmp = new ItemVenda()
            {
                Produto = produtoTmp,
                Quantidade = Convert.ToInt32(this.txtQuantidade.Text),
                Valor = Convert.ToDouble(this.txtPreço.Text),
                Desconto = Convert.ToDouble(this.txtDesconto.Text)
            };

            this.Itens.Add(itemVendaTmp);

            this.tblListaCompras.DataSource = this.Itens;
            this.tblListaCompras.Refresh();
        }

        private ResultadoOperacao ValidarCampos()
        {
            //Validar produto selecionado.

            if(txtPreço.TextLength == 0)
            {
                this.txtPreço.Focus();
                return new ResultadoAviso("O preço não foi informado.");
            }

            if(txtQuantidade.TextLength == 0)
            {
                this.txtQuantidade.Focus();
                return new ResultadoAviso("A quantidade deste item não foi informada.");
            }

            if(txtDesconto.TextLength == 0)
            {
                this.txtDesconto.Focus();
                return new ResultadoAviso("O desconto deste item não foi informado.");
            }

            return new ResultadoSucesso();
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {
            this.tblListaCompras.DataSource = this.Itens;
        }
    }
}
