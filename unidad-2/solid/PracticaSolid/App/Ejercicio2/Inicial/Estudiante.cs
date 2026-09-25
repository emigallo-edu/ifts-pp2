namespace App.Ejercicio2.Inicial
{
    public class Estudiante
    {
        public string Legajo { get; }
        public string Nombre { get; }

        public Estudiante(string legajo, string nombre)
        {
            Legajo = legajo;
            Nombre = nombre;
        }
    }
}