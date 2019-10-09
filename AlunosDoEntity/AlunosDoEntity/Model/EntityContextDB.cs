using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosDoEntity.Model
{
    public class EntityContextDB : DbContext
    {
       public DbSet<ListaAlunos> listaDeAlunos { get; set; }
    }
}
