using ProjetoSebo.data.shared;
using System;

namespace ProjetoSebo.bean
{
    public class Cliente : BaseParaBean
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public TipoSexo Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
    }
}
