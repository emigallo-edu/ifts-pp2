using Dominio.Entidades;
using Dominio.Services;
using Microsoft.EntityFrameworkCore;

namespace SQLRepository
{
    public class EstudianteRepositorioEF : EstudianteRepositorio
    {
        private readonly IDbContextFactory<DemoTPIContext> _fabrica;

        public EstudianteRepositorioEF(IDbContextFactory<DemoTPIContext> fabrica)
        {
            this._fabrica = fabrica;
        }

        public List<Estudiante> ObtenerTodos()
        {
            using DemoTPIContext contexto = this._fabrica.CreateDbContext();
            return contexto.Estudiantes
                .OrderBy(e => e.Apellido)
                .ThenBy(e => e.Nombre)
                .ToList();
        }

        public void Insertar(Estudiante estudiante)
        {
            using DemoTPIContext contexto = this._fabrica.CreateDbContext();
            contexto.Estudiantes.Add(estudiante);
            contexto.SaveChanges();
        }

        public void Eliminar(Estudiante estudiante)
        {
            using DemoTPIContext contexto = this._fabrica.CreateDbContext();
            contexto.Estudiantes.Remove(estudiante);
            contexto.SaveChanges();
        }
    }
}