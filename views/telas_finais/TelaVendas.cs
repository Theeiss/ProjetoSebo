using ProjetoSebo.bean;
using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.views.components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaVendas : BaseParaTela<VendaController>
    {
        public List<ItemVenda> Itens { get; set; }

        public TelaVendas(SeboContext context) :
            base(context, new VendaController())
        {
            Itens = new List<ItemVenda>();

            this.cbxTipo.SetContext(context);
        }

        private void BtnAdicionar_Click(object sender, System.EventArgs e)
        {
            //Criando um produto temporário para teste.
            Produto produtoTmp = new Produto()
            {
                Descricao = "Borracha",
                Local = null,
                Preco = 12,
                Quantidade = 1,
                Tipo = new TipoProduto(),
                CodigoBarras = "7891040789",
                PalavrasChave = "borracha"
            };

            ItemVenda itemVendaTmp = new ItemVenda()
            {
                Produto = produtoTmp,
                Quantidade = Convert.ToInt32(this.txtQuantidade.Text),
                Preco = Convert.ToDouble(this.txtPreco.Text),
                Desconto = Convert.ToDouble(this.txtDesconto.Text)
            };

            ResultadoOperacao resultado = Controller.ConsistirNovoItem(itemVendaTmp);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            this.Itens.Add(itemVendaTmp);

            this.tblListaCompras.DataSource = this.Itens;
            this.tblListaCompras.Refresh();
        }

        public override void TratarConsistencia(ResultadoOperacao retorno)
        {
            switch(retorno.Campo)
            {
                case VendaController.CAMPO_ITEM_PRECO: this.txtPreco.Focus(); break;
                case VendaController.CAMPO_ITEM_QUANTIDADE: this.txtQuantidade.Focus(); break;
                case VendaController.CAMPO_ITEM_DESCONTO: this.txtDesconto.Focus(); break;
            }
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {
            var data = from item in this.Itens
                       orderby item.Produto.Descricao
                       select new
                       {
                           Produto = item.Produto.ToString(),
                           item.Quantidade,
                           item.Preco,
                           item.Desconto,
                           ValorItem = item.Preco - item.Desconto,
                           ValorTotal = (item.Preco - item.Desconto) * item.Quantidade
                       };

            this.tblListaCompras.DataSource = data.ToList();
        }

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
