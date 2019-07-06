using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class TextBoxData : MaskedTextBox
    {

        public DateTime DataHora { get; set; }

        protected override void OnLeave(EventArgs e)
        {
            CalcularDataHora();

            base.OnLeave(e);
        }

        private void CalcularDataHora()
        {
            try
            {
                this.DataHora = Convert.ToDateTime(this.Text);
            }
            catch (Exception e)
            {

            }
        }

    }
}
