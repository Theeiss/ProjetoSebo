using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.views.components;


namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaDoacoes : BaseParaTela<ProdutoController> //ToDo: Criar DoacaoController
    {
        public TelaDoacoes(SeboContext context) :
            base(context, new ProdutoController())
        {
            InitializeComponent();
        }
    }
}
