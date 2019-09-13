using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0; 


            while (AskToContinue() == 1)
            {
                nome = AsktoName();
                idade = YearsOld();
            }
            Console.WriteLine($"Suas Informações: \r\n Nome: {nome} \n Idade: {idade}");
            Console.ReadKey();                   



        }

        private static void ShowInitAppText()
        {
        Console.WriteLine("-------------------");
        Console.WriteLine("--Seja bem-vindo!--");
        Console.WriteLine("-------------------");
        }
        private static int AskToContinue()
        {
            Console.WriteLine("\r\n Vamos conversar? Digite (1) para sim ou (2) para não. \r\n");
            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }
        private static string AsktoName()
        {

            Console.WriteLine("Informe seu nome:");
            return Console.ReadLine();
        }
        private static int YearsOld()
        {
            Console.WriteLine("\r\n Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("Bora chapar os coco, SEXXXTTTOOOUUUUUU!");
            else
            {
                Console.WriteLine("Tem leite na geladeira. huehuehuehuehue!!!");
                Console.WriteLine("Estou ligando para sua mãe.");
            }
            return idade;
        }
           

    }
}
