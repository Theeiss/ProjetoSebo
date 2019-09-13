using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.views.components;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaCompras : BaseParaTela<ProdutoController> //ToDo: ComprasController
    {
        public TelaCompras(SeboContext context) :
            base(context, new ProdutoController())
        {
            InitializeComponent();
        }
    }
}
