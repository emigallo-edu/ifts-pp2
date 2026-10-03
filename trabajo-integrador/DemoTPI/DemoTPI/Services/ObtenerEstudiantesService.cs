using DemoTPI.Entidades;
using DemoTPI.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTPI.Services
{
    internal class ObtenerEstudiantesService
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