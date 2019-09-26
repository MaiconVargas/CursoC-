using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            /*chamamos nossa função*/
            SomarInteiroPrimitivos();
            SomaInteirosLista();
            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra os numeros inteiros primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo de "primitivo" podemos criar uma coleção destes valores.
            int[] colecaoInteiros =
            //alocamos a memoria para a nossa coleção de valores e informamos a quantidade de momeria que vamos ocupar.
            //memoriaOcupadaInt * QuantidadeInformada
            new int[5] 
            //aqui carregamos nossa coleção de valores
            { 1,2,3,4,5 };
            //Aqui somamos os valores em nossa lista.
            Console.WriteLine(colecaoInteiros.Sum());

        }
        /// <summary>
        /// Metodo que soma todos os valores em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
            };
            Console.WriteLine(listaDeInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma a quantidade de bala das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //nossa lista de crianças foi criada e carregada em memoria
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma nova criança dentro da lista
                new Crianca()
                {
                    Nome = "Joazinho",
                    Balas = 9
                },// separamos por virgula um objeto do outro
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }

            };
            Console.WriteLine("Quantidade de balas que as crianças levaram da venda");
            Console.WriteLine(
                //soma nossa quantidade de balas
                criancas.Sum(x => x.Balas));
        }
    }
}
