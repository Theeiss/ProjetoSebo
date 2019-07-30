using System;
using System.Diagnostics;

namespace ProjetoSebo.model
{
    public class LocalProduto : BaseParaModel, IComparable
    {
        [DebuggerDisplay("{Id} - {Descricao}")]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CompareTo(object obj)
        {
            LocalProduto local = obj as LocalProduto;

            return this.Descricao.CompareTo(local.Descricao);
        }
    }
}
