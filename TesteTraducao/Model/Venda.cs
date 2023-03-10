using System.Collections.Generic;

namespace TesteTraducao.Model
{
    public class Venda
    {
        public List<ItemVenda> ListaProdutos { get; set; }
        public string FormaPagamento { get; set; }
        public string CpfCliente { get; set; }

        public Venda(string formaPagamento, string cpfCliente)
        {
            ListaProdutos = new List<ItemVenda>();
            FormaPagamento = formaPagamento;
            CpfCliente = cpfCliente;
        }

        public void AdicionarProduto(Produto produto, int quantidade)
        {
            ListaProdutos.Add(new ItemVenda(produto, quantidade));
        }

        public void RemoverProduto(Produto produto)
        {
            foreach (var item in ListaProdutos)
            {
                if (item.Produto == produto)
                {
                    ListaProdutos.Remove(item);
                    break;
                }
            }
        }

        public double CalcularValorTotal()
        {
            double total = 0;
            foreach (var item in ListaProdutos)
            {
                total += item.Produto.ValorUnitario * item.Quantidade;
            }
            return total;
        }
    }
}
