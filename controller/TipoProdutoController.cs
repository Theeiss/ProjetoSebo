using ProjetoSebo.dao;
using ProjetoSebo.model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class TipoProdutoController : BaseParaController
    {
        public ResultadoOperacao Gravar(TipoProduto tipoProduto)
        {
            ResultadoOperacao resultado = ConsistirDados(tipoProduto);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            if (Context.TiposProduto.Where(t => t.Descricao == tipoProduto.Descricao).Count() == 0)
            {
                Context.TiposProduto.Add(tipoProduto);
                Context.SaveChanges();
            }

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirDados(TipoProduto tipoProduto)
        {
            return new ResultadoSucesso();
        }

        public List<TipoProduto> BuscarTodos()
        {
            return new List<TipoProduto>(Context.TiposProduto);
        }
    }
}
