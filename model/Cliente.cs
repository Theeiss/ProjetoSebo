using System;

namespace ProjetoSebo.model
{
    public class Cliente : BaseParaModel
    {
        public enum TipoSexo
        {
            Nenhum = 0,
            Masculino,
            Feminino
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public TipoSexo Sexo { get; set; }
    }
}
