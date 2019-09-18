using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListaCarros();
        }

        public static void ListaCarros()
        {
            var conteudo = "Marca:VW,Modelo:Gol,Ano:2002;Marca:Fiat,Modelo:Pálio,Ano:1999;Marca:Fiat,Modelo:Marea,Ano:1998;Marca:Peugot,Modelo:206,Ano:2005";

            var listaDeInfo = conteudo.Split(';');

            Console.WriteLine("Carros cadastrados no sistema:");
            foreach (var item in listaDeInfo)
            {
                Console.WriteLine(item.Split(',')[1]);
            }
            Console.WriteLine("Informe um carro do sistema:");
            var CarroBusca = Console.ReadLine();
            foreach (var item in listaDeInfo)
            {
                var informacoesSplit = item.Split(',');
                var Marca = informacoesSplit[0].Split(':')[1];
                var Modelo = informacoesSplit[1].Split(':')[1];
                var Ano = informacoesSplit[2].Split(':')[1];

                if (Modelo == CarroBusca)
                {
                    Console.WriteLine($"O carro é da Marca {Marca} e foi fabricado no ano {Ano}");
                    Console.ReadKey();


                }
            }

        }


    }







}

