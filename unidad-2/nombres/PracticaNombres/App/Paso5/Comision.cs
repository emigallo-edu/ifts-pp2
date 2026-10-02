namespace App.Paso5
{
    public class Comision
    {
        private const int Legajo = 0;
        private const int Inasistencias = 1;
        private const int TrabajosNoEntregados = 2;

        private const int ClasesDelCuatrimestre = 16;
        private const int UmbralDeInasistenciasEnPorcentaje = 25;
        private const int UmbralDeTrabajosNoEntregados = 2;

        private readonly List<int[]> _estudiantes = new List<int[]>();

        public string Nombre { get; }

        public Comision(string nombre)
        {
            Nombre = nombre;
        }

        public void Registrar(int legajo, int inasistencias, int trabajosNoEntregados)
        {
            _estudiantes.Add(new int[] { legajo, inasistencias, trabajosNoEntregados });
        }

        public List<int[]> EstudiantesEnRiesgo()
        {
            List<int[]> enRiesgo = new List<int[]>();
            foreach (int[] estudiante in _estudiantes)
                if (estudiante[Inasistencias] * 100 / ClasesDelCuatrimestre >= UmbralDeInasistenciasEnPorcentaje
                    || estudiante[TrabajosNoEntregados] >= UmbralDeTrabajosNoEntregados)
                    enRiesgo.Add(estudiante);
            return enRiesgo;
        }

        public string ResumenDeRiesgo()
        {
            List<int[]> enRiesgo = EstudiantesEnRiesgo();
            string resumen;
            if (enRiesgo.Count == 0)
                resumen = $"Comisión {Nombre}: no hay estudiantes en riesgo";
            else if (enRiesgo.Count == 1)
                resumen = $"Comisión {Nombre}: hay 1 estudiante en riesgo";
            else
                resumen = $"Comisión {Nombre}: hay {enRiesgo.Count} estudiantes en riesgo";

            foreach (int[] estudiante in enRiesgo)
                resumen += $"\n  {estudiante[Legajo]}";
            return resumen;
        }
    }
}
