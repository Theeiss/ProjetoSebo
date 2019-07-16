using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class ProdutoModel : BaseParaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CodigoBarras { get; set; }
        public double Preco { get; set; }
        public TipoProdutoModel Tipo { get; set; }
        public int Quantidade { get; set; }
        public LocalProdutoModel Local { get; set; }
        public string PalavrasChave { get; set; }

        public ProdutoModel()
        {
        }

        public ProdutoModel(Produto produto)
        {
            this.Id = produto.Id;
            this.Descricao = produto.Descricao;
            this.CodigoBarras = produto.CodigoBarras;
            this.Preco = produto.Preco;
            this.Tipo = new TipoProdutoModel(produto.Tipo);
            this.Quantidade = produto.Quantidade;
            this.Local = new LocalProdutoModel(produto.Local);
            this.PalavrasChave = produto.PalavrasChave;
        }

        public Produto ConverterParaBean()
        {
            Produto produto = new Produto()
            {
                Id = this.Id,
                Descricao = this.Descricao,
                CodigoBarras = this.CodigoBarras,
                Preco = this.Preco,
                //Tipo = this.Tipo,
                Quantidade = this.Quantidade,
                //Local = this.Local,
                PalavrasChave = this.PalavrasChave
            };

            return produto;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
