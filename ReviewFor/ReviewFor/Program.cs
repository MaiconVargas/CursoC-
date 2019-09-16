using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Informar texto:");
            var conttexto = Console.ReadLine();

            for (int i = 0; i < conttexto.Length; i++)
            {
                Console.WriteLine(conttexto[i]);
            }
            Console.ReadKey();
        }
    }
}
