
using Atividade3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static List<Pessoa> listaCarros = new List<Pessoa>();

        static void Main(string[] args)
        {
            Teste();
        }

        private static void Teste() 
        {
            
            Console.WriteLine(" Digite a seguir as informações do carro. \n Marca:");
            var marcaCarro = Console.ReadLine();
            Console.WriteLine("Modelo:");
            var modeloCarro = Console.ReadLine();
            Console.WriteLine("Ano:");
            var anoCarro = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor:");
            var valorCarro = double.Parse(Console.ReadLine());

            Console.WriteLine("\n --------------------------------------------- \n");

            listaCarros.Add(new Pessoa()
            {
                Marca = marcaCarro,
                Modelo = modeloCarro,
                Ano = anoCarro,
                Valor = valorCarro
            }); ;
        

            Console.WriteLine("Deseja cadastrar outro veiculo? Responda com (sim) ou (não)");
            switch (Convert.ToString(Console.ReadLine()))
            {
                case "sim":
                    Teste();
                    
                    break;

                case "não":

                    Console.WriteLine(" Veiculos cadastrados : \n");
                    Console.WriteLine(" ===================== \n");
                    listaCarros.ForEach(i => Console.WriteLine($" Marca: {i.Marca} \n Modelo:{i.Modelo} \n Ano:{i.Ano} \n Valor:{i.Valor} \n\n"));

                    Console.ReadKey();

                    break;

                default:
                    Console.WriteLine("Trouxa, digita certo sa merda!!!");
                    Console.ReadKey();

                    break;



                    
            }
            
        }
    }
}
