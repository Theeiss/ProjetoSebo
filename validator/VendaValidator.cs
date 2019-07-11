using ProjetoSebo.error;
using ProjetoSebo.model;
using System;

namespace ProjetoSebo.validator
{
    public class VendaValidator
    {
        public ResultadoOperacao ConsistirDataHora(DateTime dataHora)
        {
            if (dataHora > DateTime.Now)
                return new ResultadoAviso("A data e hora da venda não pode ser futura.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirCliente(ClienteModel cliente)
        {
            return new ResultadoSucesso();
        }
    }
}
