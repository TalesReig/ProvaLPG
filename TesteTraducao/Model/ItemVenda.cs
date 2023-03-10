using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTraducao.Model
{
    public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}
