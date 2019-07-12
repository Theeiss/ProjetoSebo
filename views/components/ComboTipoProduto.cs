using ProjetoSebo.bean;
using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class ComboTipoProduto : ComboBox
    {
        private TipoProdutoController TpProdCtrl { get; set; }
        private List<TipoProduto> TiposProduto { get; set; }
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
            this.TiposProduto = this.TpProdCtrl.BuscarTodos();

            this.TiposProduto.Sort();

            this.Items.Clear();
            this.TiposProduto.ForEach(tipo => this.Items.Add(tipo.Descricao));
        }
        protected override void OnDropDown(EventArgs e)
        {
            Carregar();

            base.OnDropDown(e);
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

            base.OnLostFocus(e);
        }

        public void SetContext(SeboContext context)
        {
            TpProdCtrl.Context = context;

            Carregar();
        }
    }
}
