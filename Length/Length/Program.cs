using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = ("Eu Maicon gosto muito de jogar gta online, quando eu Maicon jogo GTA eu domino a sessão " +
                "e quando eu Maicon e meus amigos ficamos online fazemos várias missões");
            //Verificar a quantidade de caracteres

            Console.WriteLine(texto);
            Console.WriteLine($"A frase contém: {texto.Length} caracteres.");
            Console.WriteLine("\n \n \n");
            //Replace
            texto = texto.Replace("Maicon", "1").Replace("eu", "2").Replace(" GTA", "3").Replace("gta", "4");
            Console.WriteLine(texto);
            Console.WriteLine($"A frase contém: {texto.Length} caracteres.");
            Console.WriteLine("\n \n \n");
            //Replace2
            texto = texto.Replace("Maicon", "1").Replace("eu", "2").Replace(" GTA", "3").Replace("gta", "4").Replace("quando", "5").Replace("online", "6");
            Console.WriteLine(texto);
            Console.WriteLine($"A frase contém: {texto.Length} caracteres.");

            Console.ReadKey();

        }
    }
}
