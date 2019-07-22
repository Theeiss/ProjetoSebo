using ProjetoSebo.bean;
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

            Context.Produtos.Add(new ProdutoModel(produto));
            Context.SaveChanges();

            return new ResultadoSucesso("Produto cadastrado com sucesso.");
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaBean dados)
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
            List<Produto> produtos = new List<Produto>();

            foreach (ProdutoModel produtoTmp in Context.Produtos)
            {
                produtos.Add(produtoTmp.ConverterParaBean());
            }

            return produtos;
        }

        public List<Produto> Buscar(Produto produtoFiltro)
        {
            ProdutoModel filtro = new ProdutoModel(produtoFiltro);
            List<Produto> produtos = new List<Produto>();
            IQueryable<ProdutoModel> resultado = Context.Produtos;

            if (filtro.Id != 0)
                resultado = resultado.Where(produto => produto.Id == filtro.Id);

            if (!string.IsNullOrEmpty(filtro.Descricao))
                resultado = resultado.Where(produto => produto.Descricao == filtro.Descricao);

            if (!string.IsNullOrEmpty(filtro.CodigoBarras))
                resultado = resultado.Where(produto => produto.CodigoBarras == filtro.CodigoBarras);

            if (filtro.Tipo != null)
                resultado = resultado.Where(produto => produto.Tipo == filtro.Tipo);

            if (filtro.Local != null)
                resultado = resultado.Where(produto => produto.Local == filtro.Local);

            if (!string.IsNullOrEmpty(filtro.PalavrasChave))
                resultado = resultado.Where(produto => produto.PalavrasChave.Contains(produto.PalavrasChave)); //Tem que trocar para ser uma lista de string.

            foreach (ProdutoModel produto in resultado)
            {
                produtos.Add(produto.ConverterParaBean());
            }

            return produtos;
        }
    }
}
