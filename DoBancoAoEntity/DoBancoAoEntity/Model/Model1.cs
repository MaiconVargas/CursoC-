namespace DoBancoAoEntity.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Carros> Carros { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vendas> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carros>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Carros>()
                .HasMany(e => e.Vendas)
                .WithRequired(e => e.Carros)
                .HasForeignKey(e => e.Carro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marcas>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Marcas>()
                .HasMany(e => e.Carros)
                .WithRequired(e => e.Marcas)
                .HasForeignKey(e => e.Marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Vendas>()
                .Property(e => e.Valor)
                .HasPrecision(19, 4);
        }
    }
}
