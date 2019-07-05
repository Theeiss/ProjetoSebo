using ProjetoSebo.error;

namespace ProjetoSebo.validator
{
    public class ProdutoValidator
    {
        public ResultadoOperacao ConsistirDescricao(string descricao)
        {
            if (descricao.Length == 0)
                return new ResultadoAviso("Descrição deve ser informada");

            return new ResultadoSucesso();
        }
    }
}
