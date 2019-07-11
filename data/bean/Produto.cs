namespace ProjetoSebo.bean
{
    public class Produto : BaseParaBean
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CodigoBarras { get; set; }
        public double Preco { get; set; }
        public TipoProduto Tipo { get; set; }
        public int Quantidade { get; set; }
        public LocalProduto Local { get; set; }
        public string PalavrasChave { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
