using System;
using System.Collections.Generic;

namespace ProjetoSebo.bean
{
    public class Venda : BaseParaBean
    {
        public int Id { get; set; }
        public List<ItemVenda> Itens { get; private set; }
        public DateTime DataHoraVenda { get; set; }
        public Cliente Cliente { get; set; }

        public void AdicionarItemVenda(ItemVenda item)
        {
            if (item == null)
                return;

            this.Itens.Add(item);
        }
    }
}
