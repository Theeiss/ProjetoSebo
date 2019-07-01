using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaVendas : BaseParaTela<VendasController>
    {
        public List<ItemVenda> Itens { get; set; }
        private DataGridView gridViewItemVenda = new DataGridView();

        public TelaVendas(SeboContext context) :
            base(context, new VendasController())
        {
            Itens = new List<ItemVenda>();

            InitializeComponent();

            this.cbxTipo.SetContext(context);
        }

        private void BtnAdicionar_Click(object sender, System.EventArgs e)
        {
            ResultadoOperacao resultado = ValidarCampos();
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            //Criando um produto temporário para teste.
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
                Preco = Convert.ToDouble(this.txtPreco.Text),
                Desconto = Convert.ToDouble(this.txtDesconto.Text)
            };

            this.Itens.Add(itemVendaTmp);

            this.tblListaCompras.DataSource = this.Itens;
            this.tblListaCompras.Refresh();
        }

        private ResultadoOperacao ValidarCampos()
        {
            //Validar produto selecionado.

            if (txtPreco.TextLength == 0)
            {
                this.txtPreco.Focus();
                return new ResultadoAviso("O preço não foi informado.");
            }

            double preco = Convert.ToDouble(txtPreco.Text);
            ResultadoOperacao resultado = this.Controller.ControllerItemVenda.ConsistirPreco(preco);
            if (resultado.VerificarFalhaOperacao())
            {
                this.txtPreco.Focus();
                return resultado;
            }

            if(txtQuantidade.TextLength == 0)
            {
                this.txtQuantidade.Focus();
                return new ResultadoAviso("A quantidade deste item não foi informada.");
            }

            int quantidade = Convert.ToInt32(this.txtQuantidade.Text);
            resultado = this.Controller.ControllerItemVenda.ConsistirQuantidade(quantidade);
            if(resultado.VerificarFalhaOperacao())
            {
                this.txtQuantidade.Focus();
                return resultado;
            }

            if(txtDesconto.TextLength == 0)
            {
                this.txtDesconto.Focus();
                return new ResultadoAviso("O desconto deste item não foi informado.");
            }

            double desconto = Convert.ToDouble(this.txtDesconto.Text);
            resultado = Controller.ControllerItemVenda.ConsistirDesconto(desconto);
            if (resultado.VerificarFalhaOperacao())
            {
                this.txtDesconto.Focus();
                return resultado;
            }

            return new ResultadoSucesso();
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {
            var data = from item in this.Itens
                       orderby item.Produto.Descricao
                       select new
                       {
                           Produto = item.Produto.Descricao,
                           item.Quantidade,
                           item.Preco,
                           item.Desconto,
                           ValorItem = item.Preco - item.Desconto,
                           ValorTotal = (item.Preco - item.Desconto) * item.Quantidade
                       };

            this.tblListaCompras.DataSource = data.ToList();
        }
    }
}
