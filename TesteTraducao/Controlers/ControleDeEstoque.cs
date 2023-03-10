using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTraducao.Model;

namespace TesteTraducao.Controlers
{
    public class ControleDeEstoque
    {
        private readonly List<Produto> produtos;
        private readonly List<Venda> vendas;

        public ControleDeEstoque()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public Produto SelecionarPorId(int id)
        {
            return produtos.FirstOrDefault(p => p.Id == id);
        }

        public void RemoverProduto(int id)
        {
            int index = produtos.FindIndex(p => p.Id == id);

            if (index >= 0)
            {
                produtos.RemoveAt(index);
                Console.WriteLine($"Produto com ID {id} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto com ID {id} não encontrado.");
            }
        }

        public List<Produto> SelecionarTodos()
        {
            return produtos;
        }

        public int ConsultarEstoque(Produto produto)
        {
            return produto.QuantidadeEstoque;
        }

        public void VenderProduto(Produto produto, int quantidade)
        {
            if (produto.QuantidadeEstoque < quantidade)
            {
                throw new InvalidOperationException("Produto não disponível em estoque.");
            }

            produto.QuantidadeEstoque -= quantidade;
        }
    }
}
