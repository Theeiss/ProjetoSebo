using ProjetoSebo.model;
using ProjetoSebo.controller;
using ProjetoSebo.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class TextBoxProduto : TextBox
    {
        public ProdutoController ProdutoController { get; set; }
        public TipoProduto Tipo { get; set; }       
        public Produto Produto { get; set; }

        private AutoCompleteStringCollection _valores;
        private Dictionary<string, Produto> _produtos;

        public TextBoxProduto()
        {
            this.ProdutoController = new ProdutoController();
            InitializeComponent();
        }

        public TextBoxProduto(IContainer container)
        {
            this.ProdutoController = new ProdutoController();
            container.Add(this);
            InitializeComponent();
        }

        public void SetContext(SeboContext context)
        {
            ProdutoController.Context = context;
        }

        protected override void OnEnter(EventArgs e)
        {
            Carregar();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            Buscar(this.Text);

            base.OnLeave(e);
        }

        private void Buscar(string pesquisa)
        {
            try
            {
                this.Produto = this._produtos[pesquisa.ToLower()];
            }
            catch (KeyNotFoundException e)
            {
                this.Produto = null;
                Clear();   
            }
        }

        private void Carregar()
        {
            if (this._produtos == null)
                this._produtos = new Dictionary<string, Produto>();

            if (this._valores == null)
                this._valores = new AutoCompleteStringCollection();

            Produto prodFiltro = new Produto()
            {
                Tipo = this.Tipo
            };

            List<Produto> prodBanco = this.ProdutoController.Buscar(prodFiltro);

            foreach (Produto produtoTmp in prodBanco)
            {
                this._produtos.Add(produtoTmp.Descricao.ToLower(), produtoTmp);
                this._valores.Add(produtoTmp.Descricao);
            }

            this.AutoCompleteCustomSource = this._valores;
        }
    }
}
