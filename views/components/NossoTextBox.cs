using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class NossoTextBox : TextBox
    {
        public string TextoPadrao { get; set; }

        public NossoTextBox(string textoPadrao)
        {
            this.TextoPadrao = textoPadrao;
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (this.Text.Length == 0)
            {
                this.Text = this.TextoPadrao;
                this.ForeColor = Color.Blue;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (this.Text == this.TextoPadrao)
            {
                this.Clear();
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.Text.Length == 0)
            {
                this.Text = this.TextoPadrao;
                this.ForeColor = Color.Blue;
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.Text == this.TextoPadrao)
            {
                this.Clear();
                this.ForeColor = Color.Black;
            }
        }
    }
}
