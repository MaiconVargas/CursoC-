using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC2000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA 2000 PLUS MASTER POWER");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro valor: ");
            var num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            var num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------------");

            Console.WriteLine("\n");
            Console.WriteLine("Soma:" + (num1 + num2));
            Console.WriteLine("Subtração:" + (num1 - num2));
            Console.WriteLine("Multiplicação:" + (num1 * num2));
            Console.WriteLine("Divisão:" + (num1 / num2));
            Console.WriteLine("\n");

            Console.Write("Obrigado por usar a CALCULADORA 2000 PLUS MASTER POWER \n");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Aperte qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}
