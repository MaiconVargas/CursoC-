using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoInfor
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1-Calculo de área");
            Console.WriteLine("2-Mostrar ArtWork");
            Console.WriteLine("3-Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();
                    }
                    break;
                case 2:
                    {
                        desenho.mario();
                        MenuSistema();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Saindo...");
                        return;
                    }


            }

        }

        public static void CalculaArea()
        {

            Console.WriteLine("Informe a area do quadrado");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"A area é: {bibliotecaCalculos.CalculaArea(ladoQuadrado)}");
            Console.ReadKey();


        }
    }
}
