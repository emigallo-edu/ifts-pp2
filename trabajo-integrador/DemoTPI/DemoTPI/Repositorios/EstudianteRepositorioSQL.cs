using DemoTPI.Entidades;
using DemoTPI.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTPI.Repositorios
{
    public class EstudianteRepositorioSQL : EstudianteRepositorio
    {

        public void Insertar(Estudiante estudiante)
        {
            // Lógica para insertar un estudiante en la base de datos
        }

        public void Actualizar(Estudiante estudiante)
        {
            // Lógica para actualizar un estudiante en la base de datos
        }

        public void Eliminar(Estudiante estudiante)
        {
            // Lógica para eliminar un estudiante de la base de datos
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
