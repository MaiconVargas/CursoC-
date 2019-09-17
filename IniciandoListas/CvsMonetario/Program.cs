using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace CvsMonetario
{
        public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor:");
            var meuValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo para converter:");
            Console.WriteLine("Euro,Dolar,Yen,BTC");

            var meuAlvo = Console.ReadLine();

            MetodosPublicos.Program.ConvertMoeda(meuValor, meuAlvo);

            Console.ReadKey();                
        }
    }
}
