using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculaareaquad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            calculadora();
        }
        public static void calculadora ()
        {
            Console.WriteLine("Calculadora para calcular a area de um quadrado");
            Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("Digite a base do quadrado:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A area do quadrado é:{num1 * num1}m²");
            Console.Write("Presione qualquer botão para fechar a calculadora...");
            Console.ReadKey();
        }
    }
}