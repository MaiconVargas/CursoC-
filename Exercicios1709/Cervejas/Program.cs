using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cervejas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListaCervejas();
        }

        public static void ListaCervejas()
        {
            var listaBreja = new List<string>();

            listaBreja.Add("Corona");
            listaBreja.Add("Budwaiser");
            listaBreja.Add("Skol");
            listaBreja.Add("Sub-zero");

            listaBreja.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }




    }
}
