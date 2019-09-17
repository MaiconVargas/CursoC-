using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Program
    {
           //var minhaListaPulmatica = new List<string>()
            static List<string> minhaListaPulmatica = new List<string>()

            {
                "Felipe",
                "Irineu",
                "Serilop"
            };

            static void Main(string[] args)
            {

            AddItensALista();

            ListaInformacoes();
                       
            Console.ReadKey();
            }

        private static void AddItensALista()
        {
            Console.Clear();
            Console.WriteLine("informe um nome:");
            minhaListaPulmatica.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Deseja informar mais valores? (s) sim ou (n) não.");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AddItensALista();

        }

         

        private static void ListaInformacoes()

            {
            Console.WriteLine("Nomes adicionados a lista");
            foreach (var item in minhaListaPulmatica)
                    Console.WriteLine($"Nome: {item} foi adicionado a lista"); 

            }
        }

    }
