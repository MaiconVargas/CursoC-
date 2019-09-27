using ListagemDeCervejas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCervejas
{
    class Program
    {
        static CervejaController CervejaController = new CervejaController();
        static void Main(string[] args)
        {
            var teste = CervejaController.GetCervejas().ToString();

            Console.WriteLine(teste);

            Console.ReadKey();
        }
    }
}
