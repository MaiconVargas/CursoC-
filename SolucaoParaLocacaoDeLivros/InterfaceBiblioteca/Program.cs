using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivrosController livrosController = new LivrosController();
        static UsuarioController usuariosController = new UsuarioController();
        static void Main(string[] args)
        {
            BoasVindas();
            ControladorDeFluxo();
            var escolhaMenu = int.MinValue;
            while (escolhaMenu != 0)
            {
                switch (MenuSistema())
                {
                    case 1:
                        MostrarUsuarios();
                        break;
                    case 2:
                        MostrarLivros();
                        break;
                    case 3:
                        ControladorDeFluxo();
                        break;
                    case 4:
                        AdcionarLivro();
                        break;
                    case 5:
                        RemoverLivroPeloID();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Até a proxima..");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que adiciona livros dentro de nossa lista, um novo registro de livro.
        /// </summary>
        private static void AdcionarLivro()

        {
            Console.WriteLine("Cadastrar livro dentro do sistema:");
            Console.WriteLine("Nome do livro para cadastro:");
            var nomeDoLivro = Console.ReadLine();
            livrosController.AdcionarLivro(new Livro()
            {
                Nome = nomeDoLivro
            });
            Console.WriteLine("Livro cadastrado com sucesso!");
            Console.ReadKey();

        }

        private static void MostrarUsuarios()
        {
            Console.Clear();
            Console.WriteLine("\r ********** Lista de usuarios! ****************** \n ");
            usuariosController.Usuario.ForEach(i => Console.WriteLine($" Login: {i.Login }\n Senha: {i.Senha} \n ----------------------"));
        }

        private static void MostrarLivros()
        {
            Console.Clear();
            Livro livro = new Livro();
            livro.Nome = "Éramos seis";

            var unic = new List<Livro>
            {
                new Livro()
                {
                    Nome = "Capitães de Areia",
                },

                new Livro()
                {
                    Nome = "Don Quixote"
                },

                new Livro()
                {
                    Nome = "Vidas Secas"
                }
            };


            Console.WriteLine("************************************* LER DEPOIS ************************************");
            livrosController.Livros.ForEach(i => Console.WriteLine($"Titulo do livro - {i.Nome}, foi adicionado na biblioteca em {i.DataCriacao.ToString("dd/MMM/yyyy")}"));
            Console.WriteLine("************************************* FIM LISTA  *************************************");
            Console.WriteLine($" \r\n Atualmente estou lendo : { livro.Nome}");
        }

        /// <summary>
        /// Verifica o usuario e senha e retorna um bollean para usar no ControladorDeFluxo 
        /// </summary>
        /// <returns></returns>
        private static bool ValidaALogin()
        {
            Console.WriteLine("Login:");
            var login = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senha = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            return usuarioController.LoginSistema(new Usuario()
            {
                Login = login,
                Senha = senha
            });

            //{
            //    Console.Clear();
            //    Console.WriteLine($"Seja bem vindo {login}!");
            //    MenuSistema();
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("O usuario ou senha não existe, tente novamente!");
            //    ValidaAcesso();
            //}


        }

        /// <summary>
        ///Fazendo um controlador de fluxo (Melhor que funções recursivas!);
        /// </summary>
        private static void ControladorDeFluxo()
        {
            while (!ValidaALogin())
            {
                Console.Clear();
                Console.WriteLine("Login ou senha inválidos!");
            }
        }

        /// <summary>
        /// Menu do sistema
        /// </summary>
        private static int MenuSistema()
        {
            Console.Clear();
            Console.WriteLine("** Escolha a opção desejada **");
            Console.WriteLine("1 - Listar Usuarios");
            Console.WriteLine("2 - Livros");
            Console.WriteLine("3 - Trocar Usuário");
            Console.WriteLine("4 - Cadastro de livros");
            Console.WriteLine("5 - Remover livros");
            Console.WriteLine("0 - Sair ");
            return int.Parse(Console.ReadKey(true).KeyChar.ToString());
        }

        /// <summary>
        /// Mensagem de Inicialização!
        /// </summary>
        private static void BoasVindas()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS");
            Console.WriteLine("================================");
            Console.WriteLine("Para acessar informe seu login e senha!!");
        }
        private static void RemoverLivroPeloID()
        {
            Console.WriteLine("Remover um livro");

            MostrarLivros();

            Console.WriteLine("Informe o ID para desativar do system");
            int livroID = int.Parse(Console.ReadLine());

            livrosController.RemoverLivroPorID(livroID);

            Console.WriteLine("Livro removido");

                


        }
    }
}
