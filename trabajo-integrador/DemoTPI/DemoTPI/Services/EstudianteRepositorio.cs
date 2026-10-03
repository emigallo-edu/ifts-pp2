using DemoTPI.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTPI.Services
{
    public interface EstudianteRepositorio
    {
        List<Estudiante> ObtenerTodos();
    }
}
