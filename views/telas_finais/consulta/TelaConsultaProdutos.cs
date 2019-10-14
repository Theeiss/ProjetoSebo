using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais.consulta
{
    public partial class TelaConsultaProdutos : BaseParaTela<ProdutoController>
    {
        public TelaConsultaProdutos(SeboContext context) :
            base(context, new ProdutoController())
        {
            InitializeComponent();
        }

        private void TelaConsultaProdutos_Load(object sender, System.EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            this.tblProdutos.DataSource = Controller.Buscar();
        }

        private void TblProdutos_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            int qtdColunas = this.tblProdutos.Columns.Count;
            foreach (DataGridViewColumn coluna in this.tblProdutos.Columns)
            {
                switch (coluna.Name)
                {
                    case "Descricao":
                        coluna.HeaderText = "Descrição";
                        break;
                    case "CodigoBarras":
                        coluna.HeaderText = "Código de Barras";
                        break;
                    case "Preco":
                        coluna.HeaderText = "Preço";
                        break;
                    case "btnEditar":
                        coluna.DisplayIndex = qtdColunas - 2;
                        break;
                    case "btnExcluir":
                        coluna.DisplayIndex = qtdColunas - 1;
                        break;
                    default:
                        coluna.Visible = false;
                        break;
                }
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void TblProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto produtoSelecionado = tblProdutos.Rows[e.RowIndex].DataBoundItem as Produto;
            if (produtoSelecionado == null)
                return;

            if (this.tblProdutos.Columns[e.ColumnIndex] == this.tblProdutos.Columns["btnEditar"])
                MessageBox.Show("Chamaremos a tela de inclusão.", "Sistema Sebo", MessageBoxButtons.OK);
            else if (this.tblProdutos.Columns[e.ColumnIndex] == this.tblProdutos.Columns["btnExcluir"])
            {
                if (MessageBox.Show("O produto será excluído. Confirma a operação?", "Sistema Sebo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResultadoOperacao resultado = this.Controller.Excluir(produtoSelecionado);
                    if (resultado.VerificarSucessoOperacao())
                        CarregarTabela();
                }
            }
        }
    }
}
