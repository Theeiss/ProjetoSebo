using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSebo.model
{
    public class Venda
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; private set; }

        public void AdicionarProduto(Produto produto)
        {
            if (produto == null)
                return;

            this.Produtos.Add(produto);
        }
    }
}
