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
    public partial class ComboLocaisProduto : ComboBox
    {
        private LocalProdutoController Controller { get; set; }
        private List<LocalProduto> LocaisProduto { get; set; }
        public LocalProduto LocalProdutoSelecionado { get; set; }
        public ComboLocaisProduto()
        {
            this.Controller = new LocalProdutoController();
            this.LocalProdutoSelecionado = new LocalProduto();

            InitializeComponent();
        }

        public ComboLocaisProduto(IContainer container)
        {
            this.Controller = new LocalProdutoController();
            this.LocalProdutoSelecionado = new LocalProduto();

            container.Add(this);

            InitializeComponent();
        }

        private void Carregar()
        {
            this.LocaisProduto = this.Controller.Buscar();

            this.LocaisProduto.Sort();

            this.Items.Clear();
            this.LocaisProduto.ForEach(tipo => this.Items.Add(tipo.Descricao));

            this.LocalProdutoSelecionado = new LocalProduto();
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

            LocalProduto localProduto = new LocalProduto
            {
                Descricao = this.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(localProduto);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                this.Text = "";
                return;

            }

            this.LocalProdutoSelecionado = Controller.BuscarPelaDescricao(this.Text);

            base.OnLostFocus(e);
        }

        public void SetContext(SeboContext context)
        {
            Controller.Context = context;

            Carregar();
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            this.LocalProdutoSelecionado = new LocalProduto();

            if (this.Text.Length == 0)
                return;

            this.LocalProdutoSelecionado = Controller.BuscarPelaDescricao(this.Text);

            base.OnLostFocus(e);
        }

        public void Limpar()
        {
            this.Text = "";
            this.LocalProdutoSelecionado = new LocalProduto();
        }
    }
}
