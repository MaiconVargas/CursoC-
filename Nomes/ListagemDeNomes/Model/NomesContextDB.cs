using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeNomes.Model
{
    class NomesContextDB : DbContext

    {
        public DbSet<Nomes> Nomes { get; set; }
    }
}
