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
        public const int CAMPO_CODIGO_BARRAS = 2;
        public const int CAMPO_TIPO = 3;
        public const int CAMPO_PRECO = 4;
        public const int CAMPO_QUANTIDADE = 5;
        public const int CAMPO_LOCAL = 6;
        public const int CAMPO_PALAVRAS_CHAVE = 7;

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

        public List<Produto> Buscar()
        {
            return Context.Produtos.ToList();
        }

        public List<Produto> Buscar(Produto filtro)
        {
            IQueryable<Produto> query = from produto in Context.Produtos
                                        where (filtro.Id == 0 || produto.Id == filtro.Id) &&
                                              (string.IsNullOrEmpty(filtro.Descricao) || produto.Descricao == filtro.Descricao) &&
                                              (string.IsNullOrEmpty(filtro.CodigoBarras) || produto.CodigoBarras == filtro.CodigoBarras) &&
                                              (filtro.Preco == 0 || produto.Preco == filtro.Preco) &&
                                              (filtro.Tipo == null || produto.Tipo.Id == filtro.Tipo.Id) &&
                                              (filtro.Quantidade == 0 || produto.Quantidade == filtro.Quantidade) &&
                                              (filtro.Local == null || produto.Local.Id == filtro.Local.Id) &&
                                              (filtro.PalavrasChave == null || produto.PalavrasChave.Contains(filtro.PalavrasChave))
                                        select produto;

            return query.ToList();
        }

        public ResultadoOperacao Excluir(Produto produto)
        {
            Context.Produtos.Remove(produto);
            Context.SaveChanges();

            return new ResultadoSucesso("Produto excluído com sucesso.");
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
    }
}
