using ProjetoSebo.dao;
using ProjetoSebo.model;
using System;
using System.Collections.Generic;

namespace ProjetoSebo.controller
{
    public class VendasController : BaseParaController
    {
        public ItemVendaController ControllerItemVenda { get; set; }

        public VendasController()
        {
            ControllerItemVenda = new ItemVendaController();
        }

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

        public ResultadoOperacao ConsistirDataHora(DateTime dataHora)
        {
            if (dataHora > DateTime.Now)
                return new ResultadoAviso("A data e hora da venda não pode ser futura.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirCliente(Cliente cliente)
        {


            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirItensVenda(List<ItemVenda> itensVenda)
        {
            if (itensVenda.Count == 0)
                return new ResultadoAviso("É necessário ter pelo menos um item para realizar uma venda.");

            return new ResultadoSucesso();
        }
    }
}
