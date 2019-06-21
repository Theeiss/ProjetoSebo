using ProjetoSebo.dao;
using ProjetoSebo.model;

namespace ProjetoSebo.controller
{
    public class VendasController
    {
        public SeboContext Context { get; set; }

        public ResultadoOperacao Gravar(Venda venda)
        {
            ResultadoOperacao resultado = ConsistirDados(venda);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            Context.Vendas.Add(venda);
            Context.SaveChanges();

            return new ResultadoSucesso("Produto cadastrado com sucesso.");
        }

        public ResultadoOperacao ConsistirDados(Venda venda)
        {
            return new ResultadoSucesso();
        }
    }
}
