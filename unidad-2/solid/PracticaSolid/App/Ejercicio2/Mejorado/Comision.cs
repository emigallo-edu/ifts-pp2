namespace App.Ejercicio2.Mejorado
{
    public class Comision
    {
        private readonly List<Estudiante> estudiantes = new();
        private readonly Dictionary<Estudiante, int> inasistencias = new();

        public string Nombre { get; }
        public int ClasesDictadas { get; }
        public IReadOnlyList<Estudiante> Estudiantes => estudiantes;

        public Comision(string nombre, int clasesDictadas)
        {
            Nombre = nombre;
            ClasesDictadas = clasesDictadas;
        }

        public void Inscribir(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
            inasistencias[estudiante] = 0;
        }

        public void RegistrarInasistencias(Estudiante estudiante, int cantidad)
        {
            inasistencias[estudiante] += cantidad;
        }

        public double PorcentajeDeInasistencias(Estudiante estudiante)
        {
            return 100.0 * inasistencias[estudiante] / ClasesDictadas;
        }
    }
}
