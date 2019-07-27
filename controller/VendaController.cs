using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class VendaController : BaseParaController
    {
        public const int CAMPO_ITEM_PRECO = 1;
        public const int CAMPO_ITEM_QUANTIDADE = 2;
        public const int CAMPO_ITEM_DESCONTO = 3;

        public ItemVendaValidator ItemVendaValidator { get; set; }
        public VendaValidator VendaValidator { get; set; }

        public VendaController()
        {
            ItemVendaValidator = new ItemVendaValidator();
            VendaValidator = new VendaValidator();
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

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            Venda venda = dados as Venda;

            ResultadoOperacao resultado = ConsistirItensVenda(venda.Itens);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirItensVenda(List<ItemVenda> itensVenda)
        {
            if (itensVenda.Count == 0)
                return new ResultadoAviso("É necessário ter pelo menos um item para realizar uma venda.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirNovoItem(ItemVenda itemVenda)
        {
            ResultadoOperacao resultado = this.ItemVendaValidator.ConsistirPreco(itemVenda.Preco);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_ITEM_PRECO;
                return resultado;
            }

            resultado = this.ItemVendaValidator.ConsistirQuantidade(itemVenda.Quantidade);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_ITEM_QUANTIDADE;
                return resultado;
            }

            resultado = this.ItemVendaValidator.ConsistirDesconto(itemVenda.Desconto);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_ITEM_DESCONTO;
                return resultado;
            }

            return new ResultadoSucesso();
        }

        public List<Venda> Buscar()
        {
            return Context.Vendas.ToList();
        }

        public List<Venda> Buscar(Venda filtro)
        {
            IQueryable<Venda> query = from venda in Context.Vendas
                                      where (filtro.Id == 0 || venda.Id == filtro.Id) &&
                                            (filtro.DataHoraVenda == DateTime.MinValue || venda.DataHoraVenda == filtro.DataHoraVenda) &&
                                            (filtro.Cliente == null || venda.Cliente == filtro.Cliente)
                                      select venda;

            return query.ToList();
        }
    }
}
