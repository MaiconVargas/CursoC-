using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para vc descobrir uma coisa que vc poderia ver sem programa:");
            var palavra = Console.ReadLine();

            Console.WriteLine($"A primeira letra da sua palavra é: {palavra[0]}\n A última letra da sua palavra é: {palavra[palavra.Length-1]}");
            Console.ReadKey();
        }
    }
}
