using ProjetoSebo.dao;
using ProjetoSebo.model;

namespace ProjetoSebo.controller
{
    public class ProdutoController : BaseParaController
    {
        public ResultadoOperacao Gravar(Produto produto)
        {
            ResultadoOperacao resultado = ConsistirDados(produto);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            Context.Produtos.Add(produto);
            Context.SaveChanges();

            return new ResultadoSucesso("Produto cadastrado com sucesso.");
        }

        public ResultadoOperacao ConsistirDados(Produto produto)
        {
            ResultadoOperacao resultado = ConsistirDescricao(produto.Descricao);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirDescricao(string descricao)
        {
            if (descricao.Length == 0)
                return new ResultadoAviso("Descrição deve ser informada");

            return new ResultadoSucesso();
        }


    }
}
