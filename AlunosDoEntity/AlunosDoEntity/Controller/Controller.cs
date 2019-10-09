using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosDoEntity.Model;

namespace AlunosDoEntity.Controller
{
    public class Controller
    {
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable<ListaAlunos> GetAlunos()
        {
            return contextDB.listaDeAlunos;

        }
        public void AddAlunos(ListaAlunos item)

        {
            contextDB.listaDeAlunos.Add(item);
            contextDB.SaveChanges();
        }
    }
}
