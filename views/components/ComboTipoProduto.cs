using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class ComboTipoProduto : ComboBox
    {
        private TipoProdutoController Controller { get; set; }
        private List<TipoProduto> TiposProduto { get; set; }
        public TipoProduto TipoProdutoSelecionado { get; set; }
        public ComboTipoProduto()
        {
            this.Controller = new TipoProdutoController();
            this.TipoProdutoSelecionado = new TipoProduto();

            InitializeComponent();
        }

        public ComboTipoProduto(IContainer container)
        {
            this.Controller = new TipoProdutoController();
            this.TipoProdutoSelecionado = new TipoProduto();

            container.Add(this);

            InitializeComponent();
        }

        private void Carregar()
        {
            this.TiposProduto = this.Controller.BuscarTodos();

            this.TiposProduto.Sort();

            this.Items.Clear();
            this.TiposProduto.ForEach(tipo => this.Items.Add(tipo.Descricao));

            this.TipoProdutoSelecionado = new TipoProduto();
        }

        protected override void OnDropDown(EventArgs e)
        {
            Carregar();

            base.OnDropDown(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (this.Text.Length == 0)
                return;

            TipoProduto tipoProduto = new TipoProduto
            {
                Descricao = this.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(tipoProduto);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                this.Text = "";
                return;

            }

            this.TipoProdutoSelecionado = Controller.BuscarPelaDescricao(this.Text);

            base.OnLostFocus(e);
        }

        public void SetContext(SeboContext context)
        {
            Controller.Context = context;

            Carregar();
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            this.TipoProdutoSelecionado = new TipoProduto();

            if (this.Text.Length == 0)
                return;

            this.TipoProdutoSelecionado = Controller.BuscarPelaDescricao(this.Text);

            base.OnLostFocus(e);
        }
    }
}
