using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
    class Program
    {
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pastas");
                Console.WriteLine("1 - Criar pastas em Meus documentos");
                Console.WriteLine("2 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Informe o nome da pasta");
                        var nomePasta = Console.ReadLine();
                        documents.CriarPastaMeusDocumentos(nomePasta);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
