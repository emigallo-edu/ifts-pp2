using DemoTPI.Entidades;
using DemoTPI.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal class EstudianteRepositorioFake : EstudianteRepositorio
    {
        public List<Estudiante> ObtenerTodos()
        {
            return new List<Estudiante>();
        }
    }
}
