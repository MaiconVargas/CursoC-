using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConversão
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversao();
        }

        private static void Conversao()
        {
            var Valor = new List<double>();

            Valor.Add(5);
            Valor.Add(8);
            Valor.Add(10);
            Valor.Add(0.05);

            Valor.ForEach(ValoresCon => Console.WriteLine(ValoresCon.ToString("C2")+" "+ FormataNumeroDecimalEmEuro(ValoresCon)+ " " + FormataNumeroDecimalEmBitCoin(ValoresCon)+ " "+ FormataNumeroDecimalEmYen(ValoresCon)));

            Console.ReadKey();
        }

        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$","Euro");
        }
       
        private static string FormataNumeroDecimalEmBitCoin(double meuNumero)
        {
            return  (meuNumero / 41733.86).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$","BTC");
        }
        private static string FormataNumeroDecimalEmYen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C5", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
    }
}
