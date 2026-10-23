using Dominio.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SQLRepository
{
    public static class ConfiguracionSQLRepository
    {
        public static IServiceCollection AgregarSQLRepository(this IServiceCollection servicios, string rutaBase)
        {
            servicios.AddDbContextFactory<DemoTPIContext>(opciones => opciones.UseSqlite($"Filename={rutaBase}"));
            servicios.AddSingleton<EstudianteRepositorio, EstudianteRepositorioEF>();
            return servicios;
        }

        public static void CrearBaseDeDatos(this IServiceProvider proveedor)
        {
            using DemoTPIContext contexto = proveedor.GetRequiredService<IDbContextFactory<DemoTPIContext>>().CreateDbContext();
            contexto.Database.EnsureCreated();
        }
    }
}