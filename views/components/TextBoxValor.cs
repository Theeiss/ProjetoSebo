using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public partial class TextBoxValor : TextBox
    {
        public enum TipoDado
        {
            dinheiro,
            inteiro,
            real
        }

        public double Valor { get; set; }
        public TipoDado Tipo { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',')
            {
                if (this.Tipo == TipoDado.inteiro)
                {
                    e.Handled = true;
                }
                else if (this.Text.Contains(","))
                {
                    if(this.SelectionLength <= 0 || !this.Text.Substring(this.SelectionStart, this.SelectionLength).Contains(","))
                    {
                        e.Handled = true;
                    }
                }
            }

            base.OnKeyPress(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            if(this.TextLength > 0)
            {
                this.Text = String.Format("{0}", this.Valor);
            }

            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            CalcularValor();

            if (this.TextLength > 0)
            {
                if (this.Tipo == TipoDado.dinheiro)
                    this.Text = String.Format("{0:C2}", this.Valor);
                else
                    this.Text = this.Valor.ToString();
            }

            base.OnLeave(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.TextLength == 0)
                this.Valor = 0;
        }

        private void CalcularValor()
        {
            if(this.TextLength == 0)
            {
                this.Valor = 0;
                return;
            }

            try
            {
                if(this.Tipo == TipoDado.dinheiro)
                {
                    this.Valor = Math.Round(double.Parse(this.Text, NumberStyles.Currency, new CultureInfo("pt-BR")), 2);
                }
                else
                {
                    this.Valor = Convert.ToDouble(this.Text);
                }
            }
            catch(Exception)
            {
                this.Clear();
            }
        }
    }
}
