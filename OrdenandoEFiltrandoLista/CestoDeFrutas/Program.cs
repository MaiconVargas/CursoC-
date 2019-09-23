using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();

            cestaDeFrutas.Add(new Fruta() {

                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 101
            });

            cestaDeFrutas.Add(new Fruta()
            {

                Id = 1,
                Nome = "Goiaba",
                Cor = "verde",
                Peso = 56
            });

            cestaDeFrutas.Add(new Fruta()
            {

                Id = 2,
                Nome = "Manga",
                Cor = "rosa",
                Peso = 350
            });

            cestaDeFrutas.Add(new Fruta()
            {

                Id = 3,
                Nome = "Banana",
                Cor = "Amarelo",
                Peso = 120
            });

            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));

            Console.WriteLine("\n ---------------------------------------------------------\n");

            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100);

            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso {i.Peso}"));

            Console.WriteLine("\n ---------------------------------------------------------\n");


            (from frutinha in cestaDeFrutas
             where frutinha.Peso > 100
             select frutinha).ToList<Fruta>()
                              .ForEach(i => Console.WriteLine($"Fruta escolhida: {i.Nome}"));

            Console.WriteLine("\n ---------------------------------------------------------\n");


            var mostrandoFindAll = cestaDeFrutas.FindAll(x => x.Cor == "Amarela" || x.Cor == "Vermelho");

            Console.WriteLine($"{mostrandoFindAll}");


            Console.ReadLine();

        }
    }
}

