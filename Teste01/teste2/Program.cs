using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Maicon cristian Vargas";
            var countFind = 0;
            for (int i = 1; i < 21; i++)
            {
                
                if ((nome[i - 1].ToString() + nome[i].ToString()) == "co") countFind++;

             }
            Console.WriteLine($"Quantidade total {countFind}");

            Console.ReadKey();
        }
    }
}
