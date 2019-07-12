using ProjetoSebo.bean;
using System;

namespace ProjetoSebo.model
{
    public class TipoProdutoModel : BaseParaModel, IComparable
    {
        public TipoProdutoModel()
        {
        }

        public TipoProdutoModel(TipoProduto tipoProduto)
        {
            this.Id = tipoProduto.Id;
            this.Descricao = tipoProduto.Descricao;
        }

        public TipoProduto ConverterParaBean()
        {
            TipoProduto tipoProduto = new TipoProduto
            {
                Id = this.Id,
                Descricao = this.Descricao
            };

            return tipoProduto;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CompareTo(object obj)
        {
            TipoProdutoModel tipo = obj as TipoProdutoModel;

            return this.Descricao.CompareTo(tipo.Descricao);
        }
    }
}
