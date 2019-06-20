using ProjetoSebo.dao;
using ProjetoSebo.model;

namespace ProjetoSebo.controller
{
    public class ProdutoController
    {
        public SeboContext Context { get; set; }

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
            return new ResultadoSucesso();
        }
    }
}
