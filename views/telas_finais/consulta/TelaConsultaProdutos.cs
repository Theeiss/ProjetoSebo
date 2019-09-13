
using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.views.components;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaConsultaProdutos : BaseParaTela<ProdutoController>
    {
        public TelaConsultaProdutos(SeboContext context) :
            base(context, new ProdutoController())
        {
            InitializeComponent();
        }
    }
}
