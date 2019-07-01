using ProjetoSebo.controller;
using ProjetoSebo.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class ComboLocais : ComboBox
    {
        private LocalController Controller { get; set; }
        private List<Local> Locais { get; set; }
        private List<Point> PosicoesExclusao { get; set; }

        public ComboLocais()
        {
            Controller = new LocalController();
        }

        private void Carregar()
        {
            this.Locais = this.Controller.BuscarTodos();
            this.PosicoesExclusao = new List<Point>();

            this.Locais.Sort();

            this.Items.Clear();
            this.Locais.ForEach(tipo => this.Items.Add(tipo.Descricao));
            this.Locais.ForEach(tipo => this.PosicoesExclusao.Add(new Point()));
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

            Local local = new Local()
            {
                Descricao = this.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(local);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            base.OnLostFocus(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Console.WriteLine("{0},{1} \r\n", e.X, e.Y);

            int index = this.PosicoesExclusao.FindIndex(p => p.X == e.X && p.Y == e.Y);
            if (index >= 0)
            {
                this.Locais.RemoveAt(index);
                this.PosicoesExclusao.RemoveAt(index);
            }
        }

        //protected override void OnDrawItem(DrawItemEventArgs e)
        //{
        //    e.DrawBackground();
        //    e.DrawFocusRectangle();

        //    if (e.Index < 0)
        //    {
        //        e.Graphics.DrawString(this.Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + this.imageList.ImageSize.Width, e.Bounds.Top);
        //    }
        //    else
        //    {
        //        string text = this.Locais[e.Index].Descricao;

        //        e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top);

        //        Point point = new Point(e.Bounds.Right - this.imageList.ImageSize.Width, e.Bounds.Top);

        //        this.imageList.Draw(e.Graphics, point, 0);

        //        this.PosicoesExclusao[e.Index] = point;

        //    }

        //    base.OnDrawItem(e);
        //}
    }
}
