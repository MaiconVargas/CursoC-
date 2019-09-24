using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pessoinhas = new List<Pessoas>();

            #region
            Pessoinhas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Dj Henrique de Ferraz",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Menor MR",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Rodolfinho",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Mr.Catra",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 5,
                Nome = "Mc WM",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 6,
                Nome = "Mc Hariel",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 7,
                Nome = "Kevinho",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 8,
                Nome = "Mc Davi",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 9,
                Nome = "Mc Don Juan",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 10,
                Nome = "Mc Charada",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 11,
                Nome = "Júlio Cocielo",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 12,
                Nome = "Mr Poladoful",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 13,
                Nome = "Vlad",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 14,
                Nome = "Hunters Clan",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 15,
                Nome = "Thiago Ventura",
                DataNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 16,
                Nome = "Thanos",
                DataNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 17,
                Nome = "Homer j Simpson",
                DataNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 18,
                Nome = "CJ",
                DataNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 64651605615032.54,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 19,
                Nome = "Mc Kekel",
                DataNascimento = DateTime.Parse("18/09/2000"),
                Carteira = 991.83,
            });
            Pessoinhas.Add(new Pessoas()
            {
                Id = 20,
                Nome = "Mia Khalifa",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00,
            });
            #endregion

            Console.WriteLine("----------------------Nome----------------------------------");

            Pessoinhas.OrderBy(x => x.Nome).ToList<Pessoas>().ForEach(i => Console.WriteLine($"{i.Nome}"));

            Console.WriteLine("----------------------Data----------------------------------");

            Pessoinhas.OrderByDescending(x => x.DataNascimento).ToList<Pessoas>().ForEach(i => Console.WriteLine($"{i.DataNascimento} - {i.Nome}"));

            Console.WriteLine("----------------------Carteira----------------------------------");

            var Lista = (from PessoasCarteira in Pessoinhas
             where PessoasCarteira.Carteira >= 500
             select PessoasCarteira).ToList<Pessoas>().OrderBy(x => x.Carteira);

            Lista.ToList().ForEach(i => Console.WriteLine($"{i.Nome} e carteira: {i.Carteira}"));

            
            Console.ReadKey();
        }
    }
}
