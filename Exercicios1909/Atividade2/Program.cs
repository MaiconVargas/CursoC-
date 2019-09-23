
using Atividade2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoas = new List<Pessoa>();
            Console.WriteLine("Digite o Nome:");
            var nomePessoa = Console.ReadLine();
            Console.WriteLine("Idade:");
            var idadePessoa = int.Parse(Console.ReadLine());
            Console.WriteLine("Sexo:");
            var sexoPessoa = char.Parse(Console.ReadLine());
            Console.WriteLine("Altura:");
            var alturaPessoa = double.Parse(Console.ReadLine());

            Console.WriteLine("\n --------------------------------------------- \n");

            listaPessoas.Add(new Pessoa()
            {
                Nome = nomePessoa ,
                Idade = idadePessoa, 
                Sexo = sexoPessoa,
                Altura = alturaPessoa
            }); ;
            
            Console.WriteLine(" Cadastro: \n");
            Console.WriteLine(" ========= \n");
            listaPessoas.ForEach(i => Console.WriteLine($" Nome: {i.Nome} \n Idade:{i.Idade} \n Sexo:{i.Sexo} \n Altura:{i.Altura} \n\n"));

            Console.ReadKey();
        }
    }
}
