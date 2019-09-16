using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1

{
    class Program
    {
        static void Main(string[] args)
        {
            Private1();
        }
        private static void Private1()
        {
            Console.WriteLine("Digite seu nome:");
            var seunome = Console.ReadLine();

            var texto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace";

            Console.WriteLine("Digite a balavra de busca:");
            var palavraBusca = Console.ReadLine();

            var textoSplit = texto.Split(';');

            foreach (var item in textoSplit)
            {
                if (palavraBusca == item)
                Console.WriteLine("Palavra encontrada com sucesso!!");

            }
            Console.ReadKey();
        }
            
            

	}
            






}

