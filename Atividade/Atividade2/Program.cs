using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas vindas novo usuário. \n Informe seu nome:\n");
            var nome = Console.ReadLine();

            Console.WriteLine($"Suas Informações: \r\n Nome: {nome}");
            Console.ReadKey();   
        }
    }
}
