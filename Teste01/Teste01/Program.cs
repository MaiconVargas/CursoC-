using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numero = 0.1;
            while (true)
            {
                Console.WriteLine(numero);
                numero+=numero;

            }
        }
    }
}
