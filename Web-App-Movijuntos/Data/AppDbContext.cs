using Microsoft.EntityFrameworkCore;
using Web_App_Movijuntos.Models;

namespace Web_App_Movijuntos.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Local> Locais { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<Criterio> Criterios { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Foto> Fotos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Nascimento)
                .HasColumnType("date");
        }

    }
}