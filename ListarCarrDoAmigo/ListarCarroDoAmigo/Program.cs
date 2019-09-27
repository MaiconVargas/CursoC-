using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace ListarCarroDoAmigo
{
    class Program
    {
        static CarroController Controller = new CarroController();

        static void Main(string[] args)
        {
            Controller.GetCarros().ForEach(i => Console.WriteLine($"{i.Id}{i.Marca}{i.Modelo}"));

            Console.ReadLine();
            
        }
    }
}
