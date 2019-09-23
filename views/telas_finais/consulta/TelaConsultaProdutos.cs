using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.views.components;
using System.Linq;

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
            var data = from produto in Controller.Buscar()
                       orderby produto.Descricao
                       select new
                       {
                           produto.Descricao,
                           produto.CodigoBarras,
                           produto.Preco,
                           produto.Tipo,
                           produto.Quantidade,
                           produto.Local,
                           produto.PalavrasChave
                       };

            this.tblProdutos.DataSource = data.ToList();
        }
    }
}
