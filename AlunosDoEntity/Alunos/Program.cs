using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosDoEntity.Model;
using AlunosDoEntity.Controller;

namespace Alunos
{
    class Program
    {
        static Controller Alunos = new Controller();
        static void Main(string[] args)

        {
            var escolha = int.MinValue;
            while (escolha != 0)
            {
                escolha = menu();

                switch (escolha)
                {

                    case 1:
                        Alunos.GetAlunos()
                        .ToList<ListaAlunos>()
                        .ForEach(x => Console.WriteLine(x.Nome));

                        Console.WriteLine("Nome cadastrado com sucesso!");
                        Console.WriteLine("Aperte qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Digite um nome para adicionar a lista:");
                        Alunos.AddAlunos(
                   new ListaAlunos()
                   {
                       Nome = Console.ReadLine()
                   });
                        Console.WriteLine("Aperte qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    #region
                    case 5:
                        
                        Console.WriteLine(":... ... ... ..,,~”:::::::::::::::::::::::::::::::::::::::::::::::::::::::~,, ");
                        Console.WriteLine("... ... ... ..,,-“:::::::::::::::/::::::/::::::::::::::::|:::::::::::::::-,::-,::”-,");
                        Console.WriteLine("... ... ...,-“:::::,-“:::/:::::/::::::/:|:::::::::::::::::|::::::::::::::::|::::|::|");
                        Console.WriteLine("... ... .,-“:::::::/:::::|:::::|:::::::|:|::::::::::::::::::||:::::::::::::|:|:::::|");
                        Console.WriteLine("... ... /::::::::::|::::::|:::::||::::::|:|::::::::::::::::::||::::::::::::|:/::::::");
                        Console.WriteLine("... .../::::::::::::|:::::::|::::'|”-,::::|:|,:::::::::::::::|:|::::::::::,//::::: :");
                        Console.WriteLine("... ../::::::::::::::'|::::::|-,:::”-,”-,::|-,”-,,:::::::::/: |::::::,-“//::::::/:::");
                        Console.WriteLine("... ./:::::::::::::::::”,-,,::||”~-,,|,:”~-|”: :”-,::::/: :/:::,-“: :/::,-“/:::,-“::");
                        Console.WriteLine("... /::::::::::::::::::/,__”-,|: : ,,-~”,”',-,: : :|:/: :/:,-“,-~,”-,”:/:,,-“:,-//' ");
                        Console.WriteLine("... |:::::::::::::::::/:o:::o: :,,-“/. ,-“:|.|: : : : “: -'”:/./,--,”|.'|”/::::::|-“");
                        Console.WriteLine("...|::::::/:::::::::/::/|:::|.|: : |.|'|¯;|..|.|: : : : : : : :|.|| ;|././:|:::|:::|");
                        Console.WriteLine("...|::|:::|::::::::/::'-':::'-,': : '|'|'~'_/,/: : : : : : ,: :'-|'|'~'-//|:::|:::| ");
                        Console.WriteLine("...|::|:::|::::::::/::::|:::::'|: : : “' ¯: : : : : : : : : :: : :“' ¯ : /::::'|::| ");
                        Console.WriteLine("...|::|:::|:::::::/:::::|:::::'|: : : : : : : : : : : : : : :': : : : : :/::::::|::|");
                        Console.WriteLine("... |:|:::|::::::|::::::|::::::|,: : : : : : : : : :__,: : : : : : :,-“:::::::|::| ");
                        Console.WriteLine("... .'||::|::::::|::::::||::::::|'~,: : : : : : : :'--~': : : : ,,~”|:::::::::|:/ ");
                        Console.WriteLine("... ...'|:|:::::|::::::/.|::::::|: : “~,: : : : : : : : ,,-~,”::::::'|:::::::|:/ ");
                        Console.WriteLine("... ... .||:::::|”~,/-,|:::::::|: : : : ¯”~,-,,,-~”:::,,-'|::::::::|-,,_::|/ ");
                        Console.WriteLine("... ... ..',|,::|~--'-~|:::::::|: : : : : : |::|,,-~”¯..__|::::::::|... .'| ");
                        Console.WriteLine("... ..,~”': : ||: : : : : |::::::|: : : : : : |¯”'~~”~,”,: : |:::::::|... / ");
                        Console.WriteLine("..,-“: : : : : :|: : : : : :|::::::|: : : : : : |: : : : : : “~'-,:|::::::|./ ");
                        Console.WriteLine("..|: : : : : : : |: : : : : : |::::| : : : : : : : : : : : : : : :”-,-|::::|/ ");
                        Console.WriteLine("..| : : : : : : : : : : : : : |::::|:: : : : : : : : : : : : : : : : :”-'|,| ");
                        Console.WriteLine("..|: : : : : : : : : : : : : : |:::|: : : : : : : : : : : : : : : : :”-'|,, ");
                        Console.WriteLine("..|: : : : : : : : : : :'|: : : :|:| : : : : : : : :~,,: : : : : : : : : “~-.,_ ");
                        Console.WriteLine("...| : : : : : : : : : : :|: /: : : : : : : : : : : : : : : “,: : : : : : : : : : ::");
                        Console.WriteLine("... .|: : : : : : : : : : :||: : : : : : : : :_._ : : : : : : |: : : : : : : : : : :");
                        Console.WriteLine("... ...|: : : : : : : : : : |: : : : : : : : ( O ) : : : : : : |: : : : : : : : : : ");
                        Console.WriteLine("... ... .| : : : : : : : : : '|': : : : : : : ::*:: : : : : : : :|: : : : : : : : : |0)");
                        Console.WriteLine("... ... ...| : : : : : : : : : '|: : : : : : : : : : : : : : : :/: : : : : : : : : :::");
                        Console.WriteLine("... ... .....| : : : : : : : : : |: : : : : : : : : : : : : ,-“: : : : : : : : : : :");
                        Console.WriteLine("... ... ... ...| : : : : : : : : : |: : : : : : : : : _=: : : : : : ',_.: : : : : : ");
                        Console.WriteLine("... ... ... ... |,: : : : : : : : : |: ::”'~---~”: : : : : : : : : : : : : = ::”~~ ");
                        Console.WriteLine("... ... ... ... ..'|,: : : : : : : : : |: : : : : : : : : : : : : : : : : : : '|: : ");
                        Console.WriteLine("... ... ... ... ... .|, : : : : : : : : '|: : : : : : : : : : : : : : : : : : :|: : ");
                        Console.WriteLine("... ... ... ... ... ...|,: : : : : : : : :| : : : : : : : : : : : : : : : : : |: : :");
                        Console.WriteLine("... ... ... ... ... ... ..| : : : : : : : : |: : : : : : : : : : : : : : : : :|: : :");
                        Console.WriteLine("... ... ... ... ... ... ...||,: : : : : : : :|, : : : : : : : : : : : : : : :/: : : ");
                        Console.WriteLine("... ... ... ... ... ... ... .|| : : : : : : : :'| : : : : : : : : : : : : : :|: : : ");
                        Console.WriteLine("... ... ... ... ... ... ... ./:|: : : : : : : : :'|, : : : : : : : : : : : : |: : : ");
                        Console.WriteLine("... ... ... ... ... ... ... /: : |: : : : : : : : : '|,: : : : : : : : : : : |: : : ");
                        Console.WriteLine("... ... ... ... ... ... .../: : : '|: : : : : : : : : :'|,: : : : : : : : : : |: : :");
                        Console.WriteLine("... ... ... ... ... ... ../: : : : :|: : : : : : : : : : :|, : : : : : : : : |: : : ");
                        Console.WriteLine("... ... ... ... ... ... ,/: : : : : : :|: : : : : : : : : : '|,: : : : : : : |: : : ");
                        Console.WriteLine("... ... ... ... ... ..,-“: : : : : : : :“-,: : : : : : : : : : |: : : : : : | : : : ");
                        Console.WriteLine("... ... ... ... ... ,/ : : : : : : : : : :”-, : : : : : : : : : :|: : : : : /: : : :");
                        Console.WriteLine("... ... ... ... ..,/ : : : : : : : : : : : : :”-, : : : : : : : : :'|: : : :| : : : ");
                        Console.WriteLine("... ... ... ... ,/ : : : : : : : : : : : : : : : “-,: : : : : : : : :'|: : |: : : : ");
                        Console.WriteLine("... ... ... .../: : : : : : : : : : : : : : : : : : “-,: : : : : : : : '|: |: : : : ");
                        Console.WriteLine("... ... ... ../: : : : : : : : : : : : : : : : : : : : :“-,: : : : : : : |,|: : : : ");
                        Console.WriteLine("... ... ... ,/: : : : : : : : : : : : : : : : : : : : : : :“-,: : : : : : :|: : : : ");
                        Console.WriteLine("... ... .../-,-,”,,-,~-,,_: : : : : : : : : : : : : : : : : “-,: : : : : :'|: : :'| ");
                        Console.WriteLine("... ... ...|',/,/:||:|,|: : : “'~,,~~---,,,_: : : : : : : : : :'|: : : : : :|,: :| ");
                        Console.WriteLine("... ... ..|: :”: ||: :”: : : : : : :”-,........ ¯¯”''~~~-----~||: : : : : : |:| ");
                        Console.WriteLine("... ... ..|: : : ||: : : : : : : : : : :”-,.......................... |: : : : : : :");
                        Console.WriteLine("... ... ..| : : : : : : : : : : : : : : : :”-,....................... |: : : : : : :");
                        Console.WriteLine("... ... ..| : : : : : : : : : : : : : : : :”-,|....................,-“|: : : : : : :");
                        Console.WriteLine("... ... ..| : : : : : : : : : : : : : : : : : :”-|...............,/: : :|: : : : : :");
                        Console.WriteLine("... ... ..| : : : : : : : : : : : : : : : : : : : |,...........,/: : : :'|: : : : : ");
                        Console.WriteLine("... ... ..| : : : : : : : : : : : : : : : : : : : : |.......,/: : : : ,-~/: : ,: : |");
                        Console.WriteLine("... ... ..'|: : : : : : : : : : : : : : : : : : : : : |~”¯: : : : : |: :|: : /: :/: ");
                        Console.WriteLine("... ... ...|: : : : : : : : : : : : : : : : : : : : : |: : : : : : : :”-,,_/_,/-~”:|");
                        Console.WriteLine("... ... ...|: : : : : : : : : : : : : : : : : : : : : |: : : : : : : : : : : : : : :");

                        break;
                        #endregion
                }

            }
        }

        private static int menu()
        {
            int escolha;
            Console.WriteLine("==============================================================");
            Console.WriteLine("Escolha uma opção para a lista:");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("Pressione '1' para ver a lista de nomes cadastrados no sistema");
            Console.WriteLine("Pressione '2' cadastrar um nome no sistema");
            Console.WriteLine("Pressione '0' para sair");
            Console.WriteLine("==============================================================");
            return escolha = int.Parse(Console.ReadLine());
        }
    }
}
