using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;
using ProjetoSebo.views.telas_finais;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    public partial class TelaConsultaUsuarios : BaseParaTela<UsuarioController>
    {
        public TelaConsultaUsuarios(SeboContext context) :
            base(context, new UsuarioController())
        {
            InitializeComponent();
            //base.AtalhoTelaInclusao = new TelaUsuarios(context);
            base.AtalhoTelaConsulta = this;
            base.AtalhoTelaRelatorio = new TelaTipoProduto(context); //Tela apenas para teste
        }

        private void TelaConsultaUsuarios_Load(object sender, System.EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            this.tblUsuarios.DataSource = Controller.Buscar();
        }

        private void TblUsuarios_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            int qtdColunas = this.tblUsuarios.Columns.Count;
            foreach(DataGridViewColumn coluna in this.tblUsuarios.Columns)
            {
                switch(coluna.Name)
                {
                    case "Login":
                        coluna.HeaderText = "Login";
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

        private void TblUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuarioSelecionado = tblUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;
            if (usuarioSelecionado == null)
                return;
            
            if(this.tblUsuarios.Columns[e.ColumnIndex] == this.tblUsuarios.Columns["btnEditar"])
                MessageBox.Show("Chamaremos a tela de inclusão.", "Sistema Sebo", MessageBoxButtons.OK);
            else if(this.tblUsuarios.Columns[e.ColumnIndex] == this.tblUsuarios.Columns["btnExcluir"])
            {
                if (MessageBox.Show("O usuário será excluído. Confirma a operação?", "Sistema Sebo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResultadoOperacao resultado = this.Controller.Excluir(usuarioSelecionado);
                    if (resultado.VerificarSucessoOperacao())
                        CarregarTabela();
                }
            }
        }
    }
}
