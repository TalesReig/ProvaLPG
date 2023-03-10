using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TesteTraducao.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }

        public Produto(int id, string titulo, double valorUnitario, int quantidadeEstoque)
        {
            Id = id;
            Titulo = titulo;
            ValorUnitario = valorUnitario;
            QuantidadeEstoque = quantidadeEstoque;
            Fornecedores = new List<Fornecedor>();
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Titulo}, Preço: {ValorUnitario}, Estoque: {QuantidadeEstoque}";
        }
    }
}
