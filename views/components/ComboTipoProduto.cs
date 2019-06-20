using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class ComboTipoProduto : ComboBox
    {
        private TipoProdutoController TpProdCtrl { get; set; }
        public ComboTipoProduto()
        {
            TpProdCtrl = new TipoProdutoController();

            InitializeComponent();
        }

        public ComboTipoProduto(IContainer container)
        {
            TpProdCtrl = new TipoProdutoController();

            container.Add(this);

            InitializeComponent();
        }

        private void Carregar()
        {
            Items.Clear();

            List<TipoProduto> tiposProduto = TpProdCtrl.BuscarTodos();
            foreach (TipoProduto tipo in tiposProduto)
                Items.Add(tipo.Descricao);
        }
        protected override void OnDropDown(EventArgs e)
        {
            Carregar();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (Text.Length == 0)
                return;

            TipoProduto tipoProduto = new TipoProduto()
            {
                Descricao = this.Text
            };

            ResultadoOperacao resultado = TpProdCtrl.Gravar(tipoProduto);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }
        }

        public void SetContext(SeboContext context)
        {
            TpProdCtrl.Context = context;

            Carregar();
        }
    }
}
