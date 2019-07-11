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
        private List<Point> PosicoesExclusao { get; set; }
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
            this.PosicoesExclusao = new List<Point>();

            this.TiposProduto.Sort();

            this.Items.Clear();
            this.TiposProduto.ForEach(tipo => this.Items.Add(tipo.Descricao));
            this.TiposProduto.ForEach(tipo => this.PosicoesExclusao.Add(new Point()));
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

            bean.TipoProduto tipoProduto = new bean.TipoProduto()
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

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Console.WriteLine("{0},{1} \r\n", e.X, e.Y);

            int index = this.PosicoesExclusao.FindIndex(p => p.X == e.X && p.Y == e.Y);
            if(index >= 0)
            {
                this.TiposProduto.RemoveAt(index);
                this.PosicoesExclusao.RemoveAt(index);
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (e.Index < 0)
            {
                e.Graphics.DrawString(this.Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + this.imageList.ImageSize.Width, e.Bounds.Top);
            }
            else
            {
                string text = this.TiposProduto[e.Index].Descricao;

                e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top);

                Point point = new Point(e.Bounds.Right - this.imageList.ImageSize.Width, e.Bounds.Top);

                this.imageList.Draw(e.Graphics, point, 0);

                this.PosicoesExclusao[e.Index] = point;

            }

            base.OnDrawItem(e);
        }
    }
}
