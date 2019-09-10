using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fluxograma Biblioteca");
            Console.WriteLine("---------------------");

            Console.WriteLine("Você tem conta na biblioteca? (Responda com 'sim' ou 'não')");
            Console.Write("Sua opção:");
            switch (Convert.ToString(Console.ReadLine()))
            {
                case "sim":
                    Console.WriteLine($"Escolha um livro de seu agrado e procure um bibliotecário.");
                    break;
                case "não":
                    Console.WriteLine($"Antes de alugar um livro, você deve realizar um cadastro na biblioteca!");
                    break;
                default:
                    Console.WriteLine("Trouxa, digita certo sa merda!!!");
                    break;

            }
            Console.WriteLine("Informe o livro a ser consultado:");
            var numeroDoLivro = Console.ReadLine();
            if (numeroDoLivro == "123456")
            {
               Console.WriteLine("Livro Indisponível!!!");
               Console.ReadKey();
               return;

            }
        }
    }
}
