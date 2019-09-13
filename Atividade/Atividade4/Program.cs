using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto");
            var text = Console.ReadLine();
            Console.WriteLine($"Seu texto contém: {text.Length}");
            Console.ReadKey();
        }
    }
}
