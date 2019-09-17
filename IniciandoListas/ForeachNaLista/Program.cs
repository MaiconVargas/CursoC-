using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();

        }

        
        
        
        /// <summary>
        /// Mostra listas definidas. Data e String.
        /// </summary>


        private static void ListaDataTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));

            Console.ReadKey();
        }

        private static void ListaString ()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE");
            minhaLista.Add("SANSUMG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();

        }

        private static void ListaDeInteiros ()

        {
            var minhaLista = new List<int>();

            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);

            minhaLista.ForEach(meuNumero => Console.WriteLine(meuNumero.ToString("C2")));

            Console.ReadKey();
        }

        private static void ListaDeDecimais ()

        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.75);
            minhaLista.Add(2.63);
            minhaLista.Add(0.01);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C2")));

            Console.ReadKey();

        }

    }
}
