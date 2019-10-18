using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeNomes.Model;

namespace ListagemDeNomes.Controller
{
    public class NomesController
    {
        NomesContextDB contextDB = new NomesContextDB();

        public IQueryable<Nomes> GetNomes()
        {
            return contextDB.Nomes;
        }
        public bool AtualizaNome(Nomes item)
        {
            var nomes = contextDB.Nomes.FirstOrDefault(x => x.Id == item.Id);
            if (nomes == null)
                return false;
            else
            {
                nomes = item;
            }
            contextDB.SaveChanges();

            return true;
        }
        public bool InserirNome(Nomes item)
        {


            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;
            contextDB.Nomes.Add(item);
            contextDB.SaveChanges();
            return true;

        }

        public bool RemoverCelular(int id)
        {
            var nome = contextDB.Nomes.FirstOrDefault(x => x.Id == id);

            if (nome == null)
                return false;

            nome.Ativo = false;

            contextDB.SaveChanges();

            return true;
        }
    }
}
