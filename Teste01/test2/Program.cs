using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um texto:");

            var text = Console.ReadLine();
           
            var search = {text.Length};
            Console.ReadKey();
            
            var countFind = 0;
            Console.WriteLine("Palavra para buscar:");
            var word = Console.ReadLine();

            for (int i = 0; i < text.Length - 2; i++)
            {

                var wordToCompare = text[i].ToString() + text[i + 1].ToString() + text[i + 2].ToString();


                if (word == wordToCompare) countFind++;

            }
            Console.WriteLine($"Quantidade total {countFind}");
            Console.ReadKey();

        }
    }
}
