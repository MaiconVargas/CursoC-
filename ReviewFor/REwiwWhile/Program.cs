using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REwiwWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto:");
            var Conttexto = Console.ReadLine();

            var count = 0;

            while (count < Conttexto.Length)
            {
                Console.WriteLine(Conttexto[count]);
                count++;
            }
            Console.ReadKey();
        }
    }
}
