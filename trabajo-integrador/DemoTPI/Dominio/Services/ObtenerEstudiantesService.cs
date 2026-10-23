using Dominio.Entidades;

namespace Dominio.Services
{
    public class ObtenerEstudiantesService
    {
        private readonly EstudianteRepositorio _repositorio;

        public ObtenerEstudiantesService(EstudianteRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            //EstudianteRepositorioSQL repositorio = new EstudianteRepositorioSQL();
            List<Estudiante> estudiantes = this._repositorio.ObtenerTodos();
            if (estudiantes.Count() == 0)
            {
                throw new Exception("No se encontraron estudiantes");
            }
            return estudiantes;
        }
    }
}