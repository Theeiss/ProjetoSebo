using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSebo.model
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Desconto{ get; set; }
    }
}
