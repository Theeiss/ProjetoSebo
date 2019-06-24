using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class NossoTextBox : TextBox
    {
        public string TextoPadrao { get; private set; }

        public override string Text
        {
            get => base.Text;
            set
            {
                this.TextoPadrao = value;
                base.Text = value;
            }
        }

        public NossoTextBox()
        {
            this.Text = TextoPadrao;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.Text == this.TextoPadrao)
            {
                this.Clear();
            }

            base.OnLeave(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (this.Text.Length == 0)
            {
                this.Text = this.TextoPadrao;
                this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            }

            base.OnKeyUp(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (this.Text == this.TextoPadrao)
            {
                this.Clear();
                this.ForeColor = Color.Black;
            }

            base.OnKeyDown(e);
        }
    }
}
