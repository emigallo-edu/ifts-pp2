using Dominio.Entidades;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace DemoTPI.VIewModel
{
    // INotifyPropertyChanged avisa a la vista cuando cambia una propiedad (por ejemplo, al limpiar el formulario)
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly EstudianteRepositorio _repositorio;

        private string _nombre = string.Empty;
        private string _apellido = string.Empty;
        private string _email = string.Empty;
        private string _telefono = string.Empty;
        private string _dni = string.Empty;
        private string _mensaje = string.Empty;
        private Estudiante? _estudianteSeleccionado;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Estudiante> ListadoEstudiantes { get; set; }

        public string Nombre { get => _nombre; set => Asignar(ref _nombre, value); }
        public string Apellido { get => _apellido; set => Asignar(ref _apellido, value); }
        public string Email { get => _email; set => Asignar(ref _email, value); }
        public string Telefono { get => _telefono; set => Asignar(ref _telefono, value); }
        public string Dni { get => _dni; set => Asignar(ref _dni, value); }
        public string Mensaje { get => _mensaje; set => Asignar(ref _mensaje, value); }
        public Estudiante? EstudianteSeleccionado { get => _estudianteSeleccionado; set => Asignar(ref _estudianteSeleccionado, value); }

        public ICommand GuardarCommand { get; }
        public ICommand EliminarCommand { get; }

        // El repositorio llega por inyección de dependencias (ver MauiProgram):
        // el ViewModel no sabe si detrás hay EF Core, SQL a mano o un fake.
        public MainViewModel(EstudianteRepositorio repositorio)
        {
            this._repositorio = repositorio;
            this.ListadoEstudiantes = new ObservableCollection<Estudiante>();
            this.GuardarCommand = new Command(this.Guardar);
            this.EliminarCommand = new Command(this.Eliminar);
        }

        public void MostrarEstudiantes()
        {
            this.ListadoEstudiantes.Clear();
            ObtenerEstudiantesService service = new ObtenerEstudiantesService(this._repositorio);
            try
            {
                foreach (Estudiante estudiante in service.ObtenerEstudiantes())
                {
                    this.ListadoEstudiantes.Add(estudiante);
                }
            }
            catch (Exception ex)
            {
                this.Mensaje = ex.Message;
            }
        }

        private void Guardar()
        {
            Estudiante estudiante = new Estudiante()
            {
                Nombre = this.Nombre,
                Apellido = this.Apellido,
                Email = this.Email,
                Telefono = this.Telefono,
                Dni = this.Dni
            };

            RegistrarEstudianteService service = new RegistrarEstudianteService(this._repositorio);
            try
            {
                service.Registrar(estudiante);
                this.LimpiarFormulario();
                this.MostrarEstudiantes();
                this.Mensaje = "Estudiante guardado";
            }
            catch (Exception ex)
            {
                this.Mensaje = ex.Message;
            }
        }

        private void Eliminar()
        {
            if (this.EstudianteSeleccionado == null)
            {
                this.Mensaje = "Seleccione un estudiante de la lista";
                return;
            }

            this._repositorio.Eliminar(this.EstudianteSeleccionado);
            this.EstudianteSeleccionado = null;
            this.MostrarEstudiantes();
            this.Mensaje = "Estudiante eliminado";
        }

        private void LimpiarFormulario()
        {
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Email = string.Empty;
            this.Telefono = string.Empty;
            this.Dni = string.Empty;
        }

        private void Asignar<T>(ref T campo, T valor, [CallerMemberName] string propiedad = "")
        {
            if (EqualityComparer<T>.Default.Equals(campo, valor))
            {
                return;
            }
            campo = valor;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }
    }
}
