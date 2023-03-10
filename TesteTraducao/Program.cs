using iText.Layout.Element;
using System;
using System.Threading;
using TesteTraducao.Controlers;
using TesteTraducao.Model;

namespace TesteTraducao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Idiomas idioma = new Idiomas("en");
            Console.WriteLine(idioma.GetMensagem("Welcome"));
            Console.ReadKey();

            ControladorDeFornecedores controladorFornecedor = new ControladorDeFornecedores();
            ControleDeEstoque controleDeEstoque = new ControleDeEstoque();

            CadastrarFornecedores();

            int mainChoice = 0;
            int productChoice = 0;
            int saleChoice = 0;

            while (mainChoice != 3)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Menu de Produtos");
                Console.WriteLine("2 - Menu de Vendas");
                Console.WriteLine("3 - Sair");

                if (int.TryParse(Console.ReadLine(), out mainChoice))
                {
                    switch (mainChoice)
                    {
                        case 1:
                            while (productChoice != 4)
                            {
                                Console.WriteLine("Escolha uma opção:");
                                Console.WriteLine("1 - Adicionar Produto");
                                Console.WriteLine("2 - Remover Produto");
                                Console.WriteLine("3 - Listar Produtos");
                                Console.WriteLine("4 - Voltar");

                                if (int.TryParse(Console.ReadLine(), out productChoice))
                                {
                                    switch (productChoice)
                                    {
                                        case 1:
                                            Console.WriteLine("Digite o ID do Produto (Não repita)");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Valor do produto");
                                            double valor = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Titulo do produto:");
                                            string titulo = Console.ReadLine();
                                            Console.WriteLine("Quantidade em estoque:");
                                            int qnt = Convert.ToInt32(Console.ReadLine());
                                            Produto produto = new Produto(id, titulo, valor, qnt);
                                            controleDeEstoque.AdicionarProduto(produto);
                                            break;
                                        case 2:
                                            // Remover Produto
                                            var produtos = controleDeEstoque.SelecionarTodos();
                                            foreach (Produto item in produtos)
                                            {
                                                Console.WriteLine(item);
                                            }
                                            Console.WriteLine("Qual produto você deseja remover: ");
                                            int idRemocao = Convert.ToInt32(Console.ReadLine());
                                            controleDeEstoque.RemoverProduto(idRemocao);
                                            break;
                                        case 3:
                                            // Listar Produtos
                                            produtos = controleDeEstoque.SelecionarTodos();
                                            foreach(Produto p in produtos)
                                            {
                                                Console.WriteLine(p);
                                            }
                                            break;
                                        case 4:
                                            // Voltar
                                            break;
                                        default:
                                            Console.WriteLine("Opção inválida.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opção inválida.");
                                }

                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            while (saleChoice != 3)
                            {
                                Console.WriteLine("Escolha uma opção:");
                                Console.WriteLine("1 - Adicionar Venda");
                                Console.WriteLine("2 - Listar Vendas");
                                Console.WriteLine("3 - Voltar");

                                if (int.TryParse(Console.ReadLine(), out saleChoice))
                                {
                                    switch (saleChoice)
                                    {
                                        case 1:
                                            // Adicionar Venda
                                            break;
                                        case 2:
                                            // Listar Vendas
                                            break;
                                        case 3:
                                            // Voltar
                                            break;
                                        default:
                                            Console.WriteLine("Opção inválida.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opção inválida.");
                                }

                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }

                Console.WriteLine();
            }

            void CadastrarFornecedores()
            {
                controladorFornecedor.AdicionarFornecedor(1, "Empresa1", "Rua 1");
                controladorFornecedor.AdicionarFornecedor(2, "Empresa2", "Rua 2");
                controladorFornecedor.AdicionarFornecedor(3, "Empresa3", "Rua 3");
                controladorFornecedor.AdicionarFornecedor(4, "Empresa4", "Rua 4");
                controladorFornecedor.AdicionarFornecedor(5, "Empresa5", "Rua 5");
            }
        }
    }
}
