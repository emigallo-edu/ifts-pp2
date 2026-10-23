using Dominio.Entidades;
using Dominio.Validaciones;

namespace Dominio.Services
{
    public class RegistrarEstudianteService
    {
        private readonly EstudianteRepositorio _repositorio;

        public RegistrarEstudianteService(EstudianteRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public void Registrar(Estudiante estudiante)
        {
            if (string.IsNullOrWhiteSpace(estudiante.Nombre) || string.IsNullOrWhiteSpace(estudiante.Apellido))
            {
                throw new ArgumentException("Nombre y apellido son obligatorios");
            }
            if (!Validador.EsEmail(estudiante.Email))
            {
                throw new ArgumentException("El email no es válido");
            }
            if (!Validador.EsTelefono(estudiante.Telefono))
            {
                throw new ArgumentException("El teléfono no es válido");
            }
            if (!Validador.EsDni(estudiante.Dni))
            {
                throw new ArgumentException("El DNI no es válido");
            }

            // Se guarda sin puntos para que "12.345.678" y "12345678" sean el mismo DNI
            estudiante.Dni = estudiante.Dni.Replace(".", "").Trim();
            this._repositorio.Insertar(estudiante);
        }
    }
}