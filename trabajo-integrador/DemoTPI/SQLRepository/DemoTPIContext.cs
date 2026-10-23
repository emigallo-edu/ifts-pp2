using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SQLRepository
{
    public class DemoTPIContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        public DemoTPIContext(DbContextOptions<DemoTPIContext> opciones) : base(opciones)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entidad =>
            {
                entidad.Property(e => e.Nombre).HasMaxLength(100).IsRequired();
                entidad.Property(e => e.Apellido).HasMaxLength(100).IsRequired();
                entidad.Property(e => e.Email).HasMaxLength(200);
                entidad.Property(e => e.Telefono).HasMaxLength(30);
                entidad.Property(e => e.Dni).HasMaxLength(8);
                entidad.HasIndex(e => e.Dni).IsUnique();
            });
        }
    }
}