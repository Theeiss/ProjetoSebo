using ProjetoSebo.bean;
using System;
using System.Collections.Generic;

namespace ProjetoSebo.model
{
    public class VendaModel : BaseParaModel
    {
        public int Id { get; set; }
        public List<ItemVendaModel> Itens { get; private set; }
        public DateTime DataHoraVenda { get; set; }
        public ClienteModel Cliente { get; set; }

        public VendaModel()
        {
        }

        public VendaModel(Venda venda)
        {
            this.Id = venda.Id;
            this.DataHoraVenda = venda.DataHoraVenda;
            this.Cliente = new ClienteModel(venda.Cliente);

            venda.Itens.ForEach(item => AdicionarItemVenda(new ItemVendaModel(item)));
        }

        public void AdicionarItemVenda(ItemVendaModel item)
        {
            if (item == null)
                return;

            this.Itens.Add(item);
        }
    }
}
