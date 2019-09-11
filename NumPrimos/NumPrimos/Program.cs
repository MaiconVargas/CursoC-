using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nome para calc:");
            var NomeLength = Console.ReadLine();
            //Length é utilizado para contar o  numero de caracteres
            Console.WriteLine($"O tamanho do nome é: {NomeLength.Length}");
            Console.ReadKey();
        }
    }
}
