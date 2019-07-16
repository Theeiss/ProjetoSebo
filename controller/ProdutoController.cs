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

        public List<Produto> Pesquisar(string pesquisa)
        {
            List<Produto> lista = new List<Produto>();

            IQueryable<ProdutoModel> resultadoBusca = Context.Produtos.Where(produto => produto.Descricao.Contains(pesquisa));

            if(resultadoBusca.Count() > 0)
            {
                foreach (ProdutoModel produto in resultadoBusca)
                {
                    lista.Add(produto.ConverterParaBean());
                }
            }

            return lista;
        }
    }
}
