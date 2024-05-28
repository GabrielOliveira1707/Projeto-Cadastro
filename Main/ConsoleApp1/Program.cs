using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
    static List<Produtos> listaDeProdutos = new List<Produtos>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------ Cadastro De Produtos ------------");
                Console.WriteLine(" 1 - Digite Para Cadastrar Produto: ");
                Console.WriteLine(" 2 - Digite Para Acessar Produtos: ");
                Console.WriteLine(" 3 - Digite Para Sair Do Sistema: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarProduto();
                        break;
                    case "2":
                        MostrarProdutos();
                        break;
                    case "3":
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void CadastrarProduto()
        {
            Produtos novoProduto = new Produtos();
            Console.Write("Nome do Produto: ");
            novoProduto.Nome = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            novoProduto.Preco = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Estoque do Produto: ");
            novoProduto.Estoque = Convert.ToInt32(Console.ReadLine());
            Console.Write("Código do Produto: ");
            novoProduto.Id = Convert.ToInt32(Console.ReadLine());

            listaDeProdutos.Add(novoProduto);
            Console.WriteLine("Produto cadastrado com sucesso!\n");
        }

        static void MostrarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in listaDeProdutos)
            {
                Console.WriteLine($"Nome: {produto.Nome}," +
                $" Preço: {produto.Preco:F2}, Estoque: {produto.Estoque}, Código: {produto.Id}");
            }
            Console.WriteLine("Pressione Enter Para Continuar");
            Console.ReadLine();
        }
    }
}
