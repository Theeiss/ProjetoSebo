using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
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
            List<Produto> produtos = Controller.Buscar();
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
                    case "PalavrasChave":
                        coluna.HeaderText = "Palavras-chave";
                        break;
                    case "Tipo":
                    case "Quantidade":
                    case "Local":
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
                if (MessageBox.Show("O Produto será excluído. Confirma a operação?", "Sistema Sebo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResultadoOperacao resultado = Controller.Excluir(produtoSelecionado);
                    this.CarregarTabela();
                }
            }
        }
    }
}
