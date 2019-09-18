using MinhaPrimeiraClass.Model;
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
            var listaDeBicicleta = new List<bicicleta>();

            listaDeBicicleta.Add(new bicicleta()
            {
                Marca = "Caloi"
            });
            listaDeBicicleta.Add(new bicicleta()
            {
                Marca = "Monark"
            });
            listaDeBicicleta.Add(new bicicleta()
            {
                Marca = "Gios"
            });
            listaDeBicicleta.Add(new bicicleta()
            {
                Marca = "Viking"
            });
            listaDeBicicleta.Add(new bicicleta()
            {
                Marca = "Nathor"
            });
            listaDeBicicleta.Add(new bicicleta()
            {
                Marca = "Soul"
            });
            listaDeBicicleta.ForEach(i => Console.WriteLine($"BikeOn > Marca:{ i.Marca} Pneus: { i.Pneus}"));

            Console.ReadKey();

        }
    }
}
