using ProjetoSebo.bean;
using ProjetoSebo.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSebo.views.components
{
    public partial class TextBoxProduto : Component
    {
        public ProdutoController ProdutoController { get; set; }
        private List<Produto> ProdutosSugestao { get; set; }

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

        private void BuscarProdutos(string pesquisa)
        {
            this.ProdutosSugestao = this.ProdutoController.Pesquisar(pesquisa);
        }
    }
}
