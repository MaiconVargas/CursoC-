using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe qual será o programa a ser utilizado:");
            Console.WriteLine("Digite 1 para Arvore");
            Console.WriteLine("Digite 2 para a calculadora de quadrado");
            Console.WriteLine("Digite 3 para a lista de cerveja");
            Console.WriteLine("Digite 4 para a lista de carros");

            switch (Convert.ToString(Console.ReadLine()))
            {
                case "1":
                    Arvore.Program.arvore();
                    break;

                case "2":
                    calculaareaquad.Program.calculadora();
                    break;
                case "3":
                   Cervejas.Program.ListaCervejas();
                   break;
               case "4":
                    Carros.Program.ListaCarros();
                   break;
              
               default:
                   Console.WriteLine("Trouxa, digita certo sa merda!!!");
                    Console.ReadKey();
                   break;

            }

        }
    }
}
