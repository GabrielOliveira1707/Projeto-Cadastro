using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Cadastro De Produtos ------------");
            string Produtos = Console.ReadLine();
            switch (Produtos)
            {
                case "1":
                    Console.WriteLine(" 1 - Cadastrar Nome: ");
                    break;
                case "2":
                    Console.WriteLine(" 2 - Cadastrar Preços: ");
                break;
                case "3":
                    Console.WriteLine(" 3 - Cadastrar Estoque: ");
                break;
                    case "4":
                    Console.WriteLine(" 4 - Cadastrar Código Do Produto");
                    break;
                case "5":
                    Console.WriteLine("Digite Sair Para Sair Do Sistema!");
                    break;
            }


        }
    }
}
