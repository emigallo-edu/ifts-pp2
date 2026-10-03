using DemoTPI.Entidades;
using DemoTPI.Repositorios;
using DemoTPI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoTPI.VIewModel
{
    internal class MainViewModel
    {

        public ObservableCollection<Estudiante> ListadoEstudiantes { get; set; }

        public MainViewModel()
        {
            this.ListadoEstudiantes = new ObservableCollection<Estudiante>();
        }

        public void MostrarEstudiantes()
        {
            EstudianteRepositorioSQL repositorio = new EstudianteRepositorioSQL();
            ObtenerEstudiantesService service = new ObtenerEstudiantesService(repositorio);
            foreach (Estudiante estudiante in service.ObtenerEstudiantes())
            {
                this.ListadoEstudiantes.Add(estudiante);
            }
        }
    }
}