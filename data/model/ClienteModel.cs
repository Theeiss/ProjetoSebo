using ProjetoSebo.bean;
using ProjetoSebo.data.shared;
using System;

namespace ProjetoSebo.model
{
    public class ClienteModel : BaseParaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public TipoSexo Sexo { get; set; }
        public string Observacao { get; set; }

        public ClienteModel()
        {
        }

        public ClienteModel(Cliente cliente)
        {
            this.Id = cliente.Id;
            this.Nome = cliente.Nome;
            this.Cpf = cliente.Cpf;
            this.DataNascimento = cliente.DataNascimento;
            this.Sexo = cliente.Sexo;
            this.Observacao = cliente.Observacao;
        }
    }
}
