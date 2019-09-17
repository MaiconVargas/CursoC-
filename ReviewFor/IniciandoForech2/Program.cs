using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForech2
{
    class Program
    {
        static void Main(string[] args)
        {
            ForechComSplit();
        }
        private static void iniciandoForech1()
        {

        }
        private static void ForechComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Maicon para realizar a busca";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');

                foreach (var item in conteudoTextoSplit)

            {
                if (palavra == item);
            }

            Console.ReadKey();

        }

       
    }
}
