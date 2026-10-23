using Dominio.Entidades;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal class EstudianteRepositorioFake : EstudianteRepositorio
    {
        private readonly List<Estudiante> _estudiantes = new List<Estudiante>();

        public List<Estudiante> ObtenerTodos()
        {
            return new List<Estudiante>(this._estudiantes);
        }

        public void Insertar(Estudiante estudiante)
        {
            this._estudiantes.Add(estudiante);
        }

        public void Eliminar(Estudiante estudiante)
        {
            this._estudiantes.Remove(estudiante);
        }
    }
}
