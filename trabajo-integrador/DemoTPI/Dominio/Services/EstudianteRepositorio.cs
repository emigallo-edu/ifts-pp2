using Dominio.Entidades;

namespace Dominio.Services
{
    public interface EstudianteRepositorio
    {
        List<Estudiante> ObtenerTodos();
        void Insertar(Estudiante estudiante);
        void Eliminar(Estudiante estudiante);
    }
}