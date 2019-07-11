namespace ProjetoSebo.bean
{
    public class ItemVenda : BaseParaBean
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Desconto{ get; set; }
    }
}
