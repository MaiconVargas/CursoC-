using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Felisbino",
                "Adagberto",
                "Ezebio",
                "Irineudson"
            };

            var texto = listaDeNomes
                //No agregate temos o nome atual que estamos lendo e o proximo nome da lista 
                .Aggregate((txt, str) => txt + ", " + str);
                //No passo seguinte temos o nome "proximo" vira atual e pega o proximo da lista, até completar a lista. 
            Console.WriteLine(texto);
            Console.ReadKey();
                
        }
    }
}
