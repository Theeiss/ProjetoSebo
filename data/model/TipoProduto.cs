using System;
using System.Diagnostics;

namespace ProjetoSebo.model
{
    public class TipoProduto : BaseParaModel, IComparable
    {
        [DebuggerDisplay("{Id} - {Descricao}")]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CompareTo(object obj)
        {
            TipoProduto tipo = obj as TipoProduto;

            return this.Descricao.CompareTo(tipo.Descricao);
        }
    }
}
