using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    class CelularesContextDB : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Celular> Celulares { get; set; }

    }
}
