using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)

        {
            TelaInicial();
            
 
                var nome = InformarNome();
                IdadeBlock(nome);
            Console.ReadKey();
        }

        private static void TelaInicial()
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem-vindo!--");
            Console.WriteLine("-------------------");
        }
        private static string InformarNome()
        {

            Console.WriteLine("Informe seu nome:");
            return Console.ReadLine();
        }
        private static void IdadeBlock(string nome)
        {
            Console.WriteLine("\r\n Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            else
            {
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
            }

        }
        
    }
}
