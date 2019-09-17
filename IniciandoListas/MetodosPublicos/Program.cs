using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Conversor de mUUedas-------");
            Console.WriteLine("Informe o valor a ser convertido:");

            var valoraserconvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR, EURO, YEN, BITCOIN");

            var moedaalvoparaconverter = Console.ReadLine().ToUpper();

            ConvertMoeda(valoraserconvertido, moedaalvoparaconverter);

            Console.ReadKey();

        }

        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecimalEmEuro(minhaMoeda));
                    break;
                case "BITCOIN":
                    Console.WriteLine(FormataNumeroDecimalEmBitCoin(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecimalEmYen(minhaMoeda));
                    break;

                default:
                    Console.WriteLine("DIGITE A OPÇÃO COM LETRA MAIUSCULA");
                    break;
            }

        }

        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "Euro");
        }

        private static string FormataNumeroDecimalEmBitCoin(double meuNumero)
        {
            return (meuNumero / 41733.86).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC");
        }
        private static string FormataNumeroDecimalEmYen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C5", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

    }

}
