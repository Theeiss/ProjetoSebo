namespace ProjetoSebo.model
{
    public class Usuario : BaseParaModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
