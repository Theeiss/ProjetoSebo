using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class ItemVendaModel : BaseParaModel
    {
        public ItemVendaModel(ItemVenda itemVenda)
        {
            this.Id = itemVenda.Id;
            Produto = new ProdutoModel(itemVenda.Produto);
            this.Quantidade = itemVenda.Quantidade;
            this.Preco = itemVenda.Preco;
            this.Desconto = itemVenda.Desconto;
        }

        public ItemVendaModel()
        {

        }

        public int Id { get; set; }
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Desconto{ get; set; }
    }
}
