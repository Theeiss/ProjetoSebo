using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class LocalModel : BaseParaModel
    {
        public LocalModel(Local local)
        {
            this.Id = local.Id;
            this.Descricao = local.Descricao;
        }

        public Local GerarEntidade()
        {
            Local local = new Local();

            local.Id = this.Id;
            local.Descricao = this.Descricao;

            return local;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
