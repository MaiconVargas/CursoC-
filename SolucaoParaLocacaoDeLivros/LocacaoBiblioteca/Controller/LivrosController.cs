using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        public LivrosController()
        {
            Livros = new List<Livro>
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

        }
        public List<Livro> Livros { get; set; }

        public void AdcionarLivro (Livro parametroLivro)
        {
            Livros.Add(parametroLivro);
        }
        public void RemoverLivroPorID(int idLivro)
        {
            Livros.FirstOrDefault(x => x.Id == idLivro).Ativo = false;
        }
    }
}
