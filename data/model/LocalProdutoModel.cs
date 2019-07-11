using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class LocalProdutoModel : BaseParaModel
    {
        public LocalProdutoModel(LocalProduto localProduto)
        {
            this.Id = localProduto.Id;
            this.Descricao = localProduto.Descricao;
        }

        public LocalProdutoModel()
        {

        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
