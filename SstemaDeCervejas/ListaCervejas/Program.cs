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
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            TituloSistema();
            Console.WriteLine("_________________________________________________");
            var opcao = MenuSistema();

            #region
            /*switch (opcao)
            {
                case "1":
                    var controle = 'Y';

                    while (controle == 'Y')
                    {
                        AdicionarBreja();
                        Console.WriteLine("Adicionado com sucesso!");

                        Console.WriteLine("Deseja adicionar +1 ? ");
                        Console.WriteLine("Digite Y - Sim ou N - Nao");
                        controle = Console.ReadKey(true).KeyChar;
                    }
                    break;

                case "2":
                    ListaProdutos();
                    break;
            }*/
            #endregion

            
            while (opcao != "0")

            {
                switch (opcao)
                {
                    case "1":
                        AdicionarBreja();
                        Console.WriteLine("Adicionado com sucesso!");

                        //Console.WriteLine("Deseja adicionar +1 ? ");
                        Console.WriteLine("Digite Y - Sim ou N - Nao");
                      

                        break;
                    case "2":
                        ListaProdutos();
                        break;
                }

            }


            Console.ReadKey();
        }

        public static void AdicionarBreja()
        {
            Console.WriteLine("Para adicionar um novo produto preencha as informações abaixo:");
            Console.WriteLine("Informe o nome da cerveja:");
            var nomeCerveja = Console.ReadLine();
            Console.WriteLine("Informe o teor alcolico da breja:");
            var teorCerveja = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos litros tem cada unidade:");
            var litroCerveja = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de cada unidade:");
            var valorCerveja = double.Parse(Console.ReadLine());

            cervejaController.AdicionarCerveja(nomeCerveja, teorCerveja, litroCerveja, valorCerveja);
        }

        public static void ListaProdutos()
        {
            cervejaController.GetCervejas().ForEach(i => Console.WriteLine($"ID do produto = {i.ID}  {i.Nome}  {i.Litros}L {(i.Valor.ToString("C2"))}"));
            Console.ReadKey();
        }

        public static void TituloSistema()
        {

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||Seja bem vindo ao sistema: O VELHO CERVEJEIRO||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||");

        }

        public static string MenuSistema()
        {
            Console.WriteLine("Escolha a operação a ser realiza:\n");
            Console.WriteLine("1 - Adicionar uma cerveja no sistema.\n2 - Listar os produtos já cadastrados");
            return Convert.ToString(Console.ReadLine());
        }
    }
}
