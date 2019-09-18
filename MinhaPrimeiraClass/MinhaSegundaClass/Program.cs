using MinhaSegundaClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeCerveza = new List<Cerveza>();

            listaDeCerveza.Add(new Cerveza()
            {
               MarcaNome = "Skol",
               QTD = 5
            });
            
            listaDeCerveza.ForEach(i => Console.WriteLine($"MARCA/NOME:{ i.MarcaNome} QTD: { i.QTD}"));

            Console.ReadKey();

        }
    }
}
