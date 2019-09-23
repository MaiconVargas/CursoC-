using Atividade01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        { var ListaAmigos = new List<Class1>();

            ListaAmigos.Add(new Class1()
            {
                NomeAmigo = "Stein" ,
                TempoAmizade = 15
            });
            ListaAmigos.Add(new Class1()
            {
                NomeAmigo = "Alan",
                TempoAmizade = 20
            });
            ListaAmigos.Add(new Class1()
            {
                NomeAmigo = "Luciano",
                TempoAmizade = 05
            });

            ListaAmigos.ForEach(i => Console.WriteLine($"Voce é amigo do {i.NomeAmigo} a {i.TempoAmizade} anos"));

            Console.ReadKey();





        }
    }
}
