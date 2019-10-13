using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class TextBoxProduto : TextBox
    {
        private ListBox Lista { get; set; }
        private string ValorAnterior { get; set; }
        public string[] Valores { get; set; }
        private ProdutoController Controller { get; set; }
        private bool _isAdicionado;

        public TextBoxProduto()
        {
            Controller = new ProdutoController();

            InitializeComponent();
            EncerraLista();
        }

        public void SetContext(SeboContext context)
        {
            Controller.Context = context;
        }

        private void Carregar()
        {
            if (Controller.Context == null)
                return;

            List<Produto> produtos = Controller.Buscar();
            Valores = new string[produtos.Count];
            for (int i = 0; i < Valores.Length; i++)
            {
                Valores[i] = produtos[i].Descricao;
            }
        }

        private void MostrarLista()
        {
            if (!_isAdicionado)
            {
                Parent.Controls.Add(Lista);
                Lista.Left = Left;
                Lista.Top = Top + Height;
                _isAdicionado = true;
            }
            Lista.Visible = true;
            Lista.BringToFront();
        }

        private void EncerraLista()
        {
            Lista.Visible = false;
        }

        private void This_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateListBox();
        }

        private void This_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Tab:
                    {
                        if (Lista.Visible)
                        {
                            Text = Lista.SelectedItem.ToString();
                            EncerraLista();
                            ValorAnterior = Text;
                            this.Select(this.Text.Length, 0);
                            e.Handled = true;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if ((Lista.Visible) && (Lista.SelectedIndex < Lista.Items.Count - 1))
                            Lista.SelectedIndex++;
                        e.Handled = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if ((Lista.Visible) && (Lista.SelectedIndex > 0))
                            Lista.SelectedIndex--;
                        e.Handled = true;
                        break;
                    }
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Tab:
                    if (Lista.Visible)
                        return true;
                    else
                        return false;
                default:
                    return base.IsInputKey(keyData);
            }
        }

        private void UpdateListBox()
        {
            if (Text == ValorAnterior)
                return;

            ValorAnterior = this.Text;
            string word = this.Text;

            if (this.Valores == null)
                this.Carregar();

            if (word.Length > 0)
            {
                string[] matches = Array.FindAll(this.Valores, x => (x.ToLower().Contains(word.ToLower())));
                if (matches.Length > 0)
                {
                    MostrarLista();
                    Lista.BeginUpdate();
                    Lista.Items.Clear();
                    Array.ForEach(matches, x => Lista.Items.Add(x));
                    Lista.SelectedIndex = 0;
                    Lista.Height = 0;
                    Lista.Width = 0;
                    Focus();
                    using (Graphics graphics = Lista.CreateGraphics())
                    {
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (i < 20)
                                Lista.Height += Lista.GetItemHeight(i);
                            int itemWidth = (int)graphics.MeasureString(((string)Lista.Items[i]) + "_", Lista.Font).Width;
                            Lista.Width = (Lista.Width < itemWidth) ? itemWidth : this.Width; ;
                        }
                    }
                    Lista.EndUpdate();
                }
                else
                {
                    EncerraLista();
                }
            }
            else
            {
                EncerraLista();
            }
        }

        public List<String> ValoresSelecionados
        {
            get
            {
                String[] result = Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return new List<String>(result);
            }
        }

        public SeboContext Context { get; }
    }
}

