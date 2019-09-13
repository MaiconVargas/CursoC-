using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7

    /*Criar um console app conte a quantidade de "a","e","i","o" e "u" dentro de um texto informado
pelo usuário.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase:");
            var texto = Console.ReadLine();
            var a = 0;
            var e = 0;
            var i = 0;
            var o = 0;
            var u = 0;

            for (int t = 0; t < texto.Length - 1; t++)
            {
                if (texto[t].ToString() == "a" || texto[t].ToString() == "A")
                    a++;
                if (texto[t].ToString() == "e" || texto[t].ToString() == "E")
                    e++;
                if (texto[t].ToString() == "i" || texto[t].ToString() == "I")
                    i++;
                if (texto[t].ToString() == "o" || texto[t].ToString() == "O")
                    o++;
                if (texto[t].ToString() == "u" || texto[t].ToString() == "U")
                    u++;

            }



            Console.WriteLine($"Sua frase contém: \n {a} letras a");
            Console.WriteLine($"Sua frase contém: \n {e} letras e");
            Console.WriteLine($"Sua frase contém: \n {i} letras i");
            Console.WriteLine($"Sua frase contém: \n {o} letras o");
            Console.WriteLine($"Sua frase contém: \n {u} letras u");

            Console.ReadKey();
            

        }
    }
}
