using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class LocalProdutoModel : BaseParaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public LocalProdutoModel()
        {
        }

        public LocalProdutoModel(LocalProduto localProduto)
        {
            this.Id = localProduto.Id;
            this.Descricao = localProduto.Descricao;
        }
    }
}
