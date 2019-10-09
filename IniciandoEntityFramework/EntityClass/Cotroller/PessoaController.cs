using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Cotroller
{
    public class PessoaController
    {
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable<Pessoa> GetPessoas()
        {
            return contextDB.listaDePessoas;

        }
        public void AddPessoa(Pessoa item)
        {
            contextDB.listaDePessoas.Add(item);
            contextDB.SaveChanges();
        }
    }
}
