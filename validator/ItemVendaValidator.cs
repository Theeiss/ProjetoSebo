using ProjetoSebo.error;

namespace ProjetoSebo.validator
{
    public class ItemVendaValidator
    {
        public ResultadoOperacao ConsistirPreco(double preco)
        {
            if (preco < 0)
                return new ResultadoAviso("O preço informado para o item é inválido.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirDesconto(double desconto)
        {
            if (desconto < 0)
                return new ResultadoAviso("O desconto informado para o item é inválido.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirQuantidade(int quantidade)
        {
            if (quantidade <= 0)
                return new ResultadoAviso("É necessário informar uma quantidade positiva de itens.");

            return new ResultadoSucesso();
        }
    }
}
