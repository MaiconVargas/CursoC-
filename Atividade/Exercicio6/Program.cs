using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    //Criar um console app que quando informado o texto contendo banana ele troque esta informação
    //por laranja
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma frase que contenha varias vezes a palavra (Banana):");
            var texto = Console.ReadLine();

            texto = texto.Replace("banana", "baranja").Replace ("Banana", "Laranja");

            Console.WriteLine(texto);

            Console.ReadKey();
        }
    }
}
