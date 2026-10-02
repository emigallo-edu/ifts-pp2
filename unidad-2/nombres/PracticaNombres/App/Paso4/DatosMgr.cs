namespace App.Paso4
{
    // Maneja los datos de la comisión
    public class DatosMgr
    {
        private const int Legajo = 0;
        private const int Inasistencias = 1;
        private const int TrabajosNoEntregados = 2;

        private const int ClasesDelCuatrimestre = 16;
        private const int UmbralDeInasistenciasEnPorcentaje = 25;
        private const int UmbralDeTrabajosNoEntregados = 2;

        private readonly List<int[]> _estudiantes = new List<int[]>();

        public string Nombre { get; }

        public DatosMgr(string nombre)
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

        public string Proc()
        {
            List<int[]> l = EstudiantesEnRiesgo();
            string s;
            if (l.Count == 0)
                s = $"Comisión {Nombre}: no hay estudiantes en riesgo";
            else if (l.Count == 1)
                s = $"Comisión {Nombre}: hay 1 estudiante en riesgo";
            else
                s = $"Comisión {Nombre}: hay {l.Count} estudiantes en riesgo";

            foreach (int[] estudiante in l)
                s += $"\n  {estudiante[Legajo]}";
            return s;
        }
    }
}
