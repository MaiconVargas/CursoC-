using RevisandoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoVisual
{
    class Program
    {
        static CervejaContextDB cerveja = new CervejaContextDB();
        static void Main(string[] args)
        {
            cerveja.Cervejas.Add(new Cerveja() { Nome = "Golimar" });

            //cerveja.SaveChanges();

            cerveja.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();


        }
    }
}
