namespace App.Ejercicio3.Inicial
{
    public class Estudiante
    {
        public string Legajo { get; }
        public string Nombre { get; }
        public string Email { get; }

        public Estudiante(string legajo, string nombre, string email)
        {
            Legajo = legajo;
            Nombre = nombre;
            Email = email;
        }
    }
}
