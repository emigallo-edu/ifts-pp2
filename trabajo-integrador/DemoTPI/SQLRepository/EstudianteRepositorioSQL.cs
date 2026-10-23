using Dominio.Entidades;
using Dominio.Services;

namespace SQLRepository
{
    public class EstudianteRepositorioSQL : EstudianteRepositorio
    {

        public void Insertar(Estudiante estudiante)
        {
        }

        public void Actualizar(Estudiante estudiante)
        {
        }

        public void Eliminar(Estudiante estudiante)
        {
        }

        public List<Estudiante> ObtenerTodos()
        {
            return new List<Estudiante>()
            {
                new Estudiante() { Nombre = "Juan", Apellido = "Pérez" },
                new Estudiante() { Nombre = "María", Apellido = "González" },
                new Estudiante() { Nombre = "Pedro", Apellido = "López" }
            };
        }
    }
}