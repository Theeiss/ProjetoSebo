using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaTeste : Form
    {
        public TelaTeste()
        {
            InitializeComponent();
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = this.txtData.Data.ToString();
        }

        private void BtnTestar2_Click(object sender, EventArgs e)
        {
            this.lblResultado2.Text = this.txtValor.Valor + "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.txtValor.Clear();
        }
    }
}
