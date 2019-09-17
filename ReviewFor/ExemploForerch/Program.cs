using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplitLista();
        }
        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSlit()
        {
            Console.WriteLine("Informe seu nome:");
            var seunome = Console.ReadLine();
            var conteudoDoTexto = ($"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace");
            Console.WriteLine("informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
        }
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Eduardo,Idade:21;Nome:giomar,Idade:75;Nome:Eusebio,Idade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuarios cadastrados no sistema:");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();
            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];   
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade");

                }

            }

            Console.ReadKey();



        }
    }
}

