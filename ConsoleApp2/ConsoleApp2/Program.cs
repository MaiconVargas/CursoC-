using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC3000
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Calculadora 3000");
            Console.WriteLine("-----------------\n");
            Console.WriteLine("Digite um numero e aperte Enter");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero e aperte Enter");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha um operador:");
            Console.WriteLine("\ts - Soma");
            Console.WriteLine("\tm - Subtração");
            Console.WriteLine("\tx - Multiplicação");
            Console.WriteLine("\td - Divisão");
            Console.Write("Sua opção: ");
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Seu resultado:" + (num1 + num2));
                    break;
                case "m":
                    Console.WriteLine($"Seu resultado:" + (num1 - num2));
                    break;
                case "x":
                    Console.WriteLine($"Seu resultado:" + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Seu resultado:" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Trouxa, digita certo sa merda!!!");
                    break;
            }
            Console.Write("Presione qualquer botão para fechar a calculadora...");
            Console.ReadKey();
        }
    }
}