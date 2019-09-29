using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaConsultaCliente : BaseParaTela<ClienteController>
    {
        public TelaConsultaCliente(SeboContext context) :
            base(context, new ClienteController())
        {
            base.AtalhoTelaInclusao = new TelaClientes(context);
            base.AtalhoTelaConsulta = this;
            base.AtalhoTelaRelatorio = new TelaTipoProduto(context); //Somente para teste.

            InitializeComponent();
        }

        private void TelaConsultaCliente_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            this.tblClientes.DataSource = Controller.Buscar();
        }

        private void TblClientes_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            int qtdColunas = this.tblClientes.Columns.Count;
            foreach (DataGridViewColumn coluna in this.tblClientes.Columns)
            {
                switch (coluna.Name)
                {
                    case "Cpf":
                        coluna.HeaderText = "CPF";
                        break;
                    case "DataNascimento":
                        coluna.HeaderText = "Data Nascimento";
                        break;
                    case "Email":
                        coluna.HeaderText = "E-mail";
                        break;
                    case "Observacao":
                        coluna.HeaderText = "Observação";
                        break;
                    case "Nome":
                    case "Sexo":
                    case "Telefone":
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

        private void TblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente clienteSelecionado = tblClientes.Rows[e.RowIndex].DataBoundItem as Cliente;
            if (clienteSelecionado == null)
                return;

            if (this.tblClientes.Columns[e.ColumnIndex] == this.tblClientes.Columns["btnEditar"])
                MessageBox.Show("Chamaremos a tela de inclusão.", "Sistema Sebo", MessageBoxButtons.OK);
            else if (this.tblClientes.Columns[e.ColumnIndex] == this.tblClientes.Columns["btnExcluir"])
            {
                if (MessageBox.Show("O cliente será excluído. Confirma a operação?", "Sistema Sebo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResultadoOperacao resultado = this.Controller.Excluir(clienteSelecionado);
                    if (resultado.VerificarSucessoOperacao())
                        CarregarTabela();
                }
            }
        }
    }
}
