﻿using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaProdutos : BaseParaTela<ProdutoController>
    {
        public TelaProdutos(SeboContext context) :
            base(context, new ProdutoController())
        {
            this.cbxTipo.SetContext(context);
        }

        private void BtnGravar_Click(object sender, System.EventArgs e)
        {
            ResultadoOperacao resultado = ValidarCampos();
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            Produto produto = new Produto()
            {
                Descricao = this.txtDescricao.Text,
                CodigoBarras = this.txtCodBarras.Text,
                //Preco = Convert.ToDouble(this.txtPreco.Text),
                Quantidade = Convert.ToInt32(this.txtQuantidade),
                PalavrasChave = this.txtPalavrasChave.Text
            };

            resultado = Controller.Gravar(produto);
            if (resultado.VerificarSucessoOperacao())
                Limpar();

            resultado.Exibir();
        }

        private ResultadoOperacao ValidarCampos()
        {
            ResultadoOperacao resultado = Controller.ConsistirDescricao(this.txtDescricao.Text);
            if(resultado.VerificarFalhaOperacao())
            {
                this.txtDescricao.Focus();
                return resultado;
            }

            return new ResultadoSucesso();
        }

        private void Limpar()
        {
            this.txtDescricao.Clear();
            this.txtCodBarras.Clear();
            //this.txtPreco.Clear();
            this.txtQuantidade.Clear();
            this.txtPalavrasChave.Clear();

            this.txtDescricao.Focus();
        }

        public void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
