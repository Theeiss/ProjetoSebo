using ProjetoSebo.bean;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;

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
    }
}
