using ProjetoSebo.bean;
using ProjetoSebo.dao;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaTeste : Form
    {
        public TelaTeste(SeboContext context)
        {
            InitializeComponent();
            this.txtProduto.SetContext(context);
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

        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = this.txtProduto.Produto;

            this.lblResultadoProduto.Text = this.txtProduto.Produto == null ? "Nulo" : this.txtProduto.Produto.Descricao;
        }
    }
}
