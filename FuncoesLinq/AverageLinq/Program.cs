using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "XIAOMI Lite 6",
                    Quantidade = 8,
                    Valor = 1200
                },
                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 900
                },
                new Venda()
                {
                    Produto = "Iphone FOGÃO 3 BOCAS",
                    Quantidade = 1,
                    Valor = 5000
                }
            };

            Console.WriteLine("Media de produtos vendidos este mes");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            Console.WriteLine("Media total de vendas neste mes em R$");
            Console.WriteLine(vendas.Average(x => x.Quantidade * x.Valor ).ToString("C2"));
            Console.ReadKey();
        }
    }
}
