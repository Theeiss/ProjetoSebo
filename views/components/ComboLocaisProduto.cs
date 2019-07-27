using ProjetoSebo.model;
using ProjetoSebo.controller;
using ProjetoSebo.error;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class ComboLocaisProduto : ComboBox
    {
        private LocalProdutoController Controller { get; set; }
        private List<LocalProduto> Locais { get; set; }
        public LocalProduto LocalProdutoSelecionado { get; set; }

        public ComboLocaisProduto()
        {
            Controller = new LocalProdutoController();
            this.LocalProdutoSelecionado = new LocalProduto();
        }

        private void Carregar()
        {
            this.Locais = this.Controller.Buscar();

            this.Locais.Sort();

            this.Items.Clear();
            this.Locais.ForEach(tipo => this.Items.Add(tipo.Descricao));

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

            LocalProduto local = new LocalProduto()
            {
                Descricao = this.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(local);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            this.LocalProdutoSelecionado = local;

            base.OnLostFocus(e);
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            this.LocalProdutoSelecionado = new LocalProduto();

            if (this.Text.Length == 0)
                return;

            LocalProduto localProduto = new LocalProduto()
            {
                Descricao = this.Text
            };

            this.LocalProdutoSelecionado = Controller.BuscarPelaDescricao(this.Text);

            base.OnLostFocus(e);
        }
    }
}
