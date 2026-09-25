namespace App.Ejercicio2.Mejorado
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
