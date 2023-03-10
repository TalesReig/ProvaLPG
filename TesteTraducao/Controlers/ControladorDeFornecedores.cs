using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTraducao.Model;

namespace TesteTraducao.Controlers
{
    public class ControladorDeFornecedores
    {
        List<Fornecedor> fornecedores;

        public ControladorDeFornecedores()
        {
            fornecedores = new List<Fornecedor>();
        }

        public void AdicionarFornecedor(int id,string nome, string endereco)
        {
            Fornecedor fornecedor = new Fornecedor(id,nome, endereco);
            fornecedores.Add(fornecedor);
            Console.WriteLine($"Fornecedor {fornecedor.Nome} adicionado com sucesso.");
        }

        public void ListarFornecedores()
        {
            Console.WriteLine("Fornecedores cadastrados:");
            foreach (Fornecedor fornecedor in fornecedores)
            {
                Console.WriteLine($"ID: {fornecedor.Id} | Nome: {fornecedor.Nome} | Endereço: {fornecedor.Endereco}");
            }
        }

        public Fornecedor SelecionarFornecedorPorId(int id)
        {
            Fornecedor fornecedor = fornecedores.Find(f => f.Id == id);
            if (fornecedor == null)
            {
                Console.WriteLine($"Fornecedor com ID {id} não encontrado.");
            }
            return fornecedor;
        }
    }
}
