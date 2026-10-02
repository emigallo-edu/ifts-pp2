namespace App.Paso6
{
    public class Comision
    {
        private const int ClasesDelCuatrimestre = 16;
        private const int UmbralDeInasistenciasEnPorcentaje = 25;
        private const int UmbralDeTrabajosNoEntregados = 2;

        private readonly List<Estudiante> _estudiantes = new List<Estudiante>();

        public string Nombre { get; }

        public Comision(string nombre)
        {
            Nombre = nombre;
        }

        public void Registrar(int legajo, int inasistencias, int trabajosNoEntregados)
        {
            _estudiantes.Add(new Estudiante(legajo, inasistencias, trabajosNoEntregados));
        }

        public List<Estudiante> EstudiantesEnRiesgo()
        {
            List<Estudiante> enRiesgo = new List<Estudiante>();
            foreach (Estudiante estudiante in _estudiantes)
                if (EstaEnRiesgo(estudiante))
                    enRiesgo.Add(estudiante);
            return enRiesgo;
        }

        public string ResumenDeRiesgo()
        {
            List<Estudiante> enRiesgo = EstudiantesEnRiesgo();
            string resumen;
            if (enRiesgo.Count == 0)
                resumen = $"Comisión {Nombre}: no hay estudiantes en riesgo";
            else if (enRiesgo.Count == 1)
                resumen = $"Comisión {Nombre}: hay 1 estudiante en riesgo";
            else
                resumen = $"Comisión {Nombre}: hay {enRiesgo.Count} estudiantes en riesgo";

            foreach (Estudiante estudiante in enRiesgo)
                resumen += $"\n  {estudiante.Legajo}";
            return resumen;
        }

        private bool EstaEnRiesgo(Estudiante estudiante)
        {
            int porcentajeDeInasistencias = estudiante.Inasistencias * 100 / ClasesDelCuatrimestre;
            return porcentajeDeInasistencias >= UmbralDeInasistenciasEnPorcentaje
                || estudiante.TrabajosNoEntregados >= UmbralDeTrabajosNoEntregados;
        }
    }
}
