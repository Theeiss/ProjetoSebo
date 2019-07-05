using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class TextBoxValor : TextBox
    {
        public double Valor { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',')
            {
                if (this.Text.Contains(","))
                {
                    if(this.SelectionLength > 0 && !this.Text.Substring(this.SelectionStart, this.SelectionLength).Contains(","))
                    {
                        e.Handled = true;
                    }
                }
            }

            base.OnKeyPress(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.Text[0] == ',')
                this.Text = "0" + this.Text;

            CalcularValor();

            base.OnLeave(e);
        }

        private void CalcularValor()
        {
            if(this.TextLength == 0)
                this.Valor = 0;

            this.Valor = Convert.ToDouble(this.Text);
        }
    }
}
