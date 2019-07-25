using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class ProdutoController : BaseParaController
    {
        public const int CAMPO_DESCRICAO = 1;

        public ProdutoValidator Validator { get; set; }

        public ProdutoController()
        {
            this.Validator = new ProdutoValidator();
        }

        public ResultadoOperacao Gravar(Produto produto)
        {
            ResultadoOperacao resultado = ConsistirDados(produto);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            Context.Produtos.Add(produto);
            Context.SaveChanges();

            return new ResultadoSucesso("Produto cadastrado com sucesso.");
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            Produto produto = dados as Produto;

            ResultadoOperacao resultado = this.Validator.ConsistirDescricao(produto.Descricao);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_DESCRICAO;
                return resultado;
            }

            return new ResultadoSucesso();
        }

        public List<Produto> Buscar()
        {
            return Context.Produtos.ToList();
        }

        public List<Produto> Buscar(Produto produtoFiltro)
        {
            List<Produto> produtos = new List<Produto>();
            IQueryable<Produto> resultado = Context.Produtos;

            if (produtoFiltro.Id != 0)
                resultado = resultado.Where(produto => produto.Id == produtoFiltro.Id);

            if (!string.IsNullOrEmpty(produtoFiltro.Descricao))
                resultado = resultado.Where(produto => produto.Descricao == produtoFiltro.Descricao);

            if (!string.IsNullOrEmpty(produtoFiltro.CodigoBarras))
                resultado = resultado.Where(produto => produto.CodigoBarras == produtoFiltro.CodigoBarras);

            if (produtoFiltro.Tipo != null)
                resultado = resultado.Where(produto => produto.Tipo == produtoFiltro.Tipo);

            if (produtoFiltro.Local != null)
                resultado = resultado.Where(produto => produto.Local == produtoFiltro.Local);

            if (!string.IsNullOrEmpty(produtoFiltro.PalavrasChave))
                resultado = resultado.Where(produto => produto.PalavrasChave.Contains(produto.PalavrasChave)); //Tem que trocar para ser uma lista de string.

            return resultado.ToList();
        }
    }
}
