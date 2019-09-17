using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCarros();
            Console.ReadKey();
        }

        private static void ListaCarros()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            var listaDeInfo = conteudo.Split(';');

            Console.WriteLine("Nomes: \n");
            foreach (var item in listaDeInfo)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Aperte 'Enter' para mostrar a idade das pessoas da lista acima. OBS: As informações doas menores de idade serão ocultadas");
            var pessoa = Console.ReadLine();
            foreach (var item in listaDeInfo)
            {
                var informacoesSplit = item.Split(',');
                var Nome = informacoesSplit[0].Split(':')[1];
                var Idade = informacoesSplit[1].Split(':')[1];
                
                if (Convert.ToInt32(Idade) >= 18)
                {
                    Console.WriteLine($"O {Nome} tem {Idade} anos");
                }

            }

        }


    }







}

