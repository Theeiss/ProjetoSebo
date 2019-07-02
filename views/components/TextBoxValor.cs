using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class TextBoxValor : TextBox
    {
        public TextBoxValor()
        {
            InitializeComponent();
        }

        public TextBoxValor(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.Text, "  ^ [0-9]"))
            {
                this.Text = "";
            }
        }
    }
}
