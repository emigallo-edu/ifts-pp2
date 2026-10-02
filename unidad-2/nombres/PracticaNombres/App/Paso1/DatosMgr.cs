namespace App.Paso1
{
    // Maneja los datos de la comisión
    public class DatosMgr
    {
        private string m_com;
        private List<int[]> lstAlumnos = new List<int[]>();

        public DatosMgr(string com)
        {
            m_com = com;
        }

        public void Add(int a1, int a2, int a3)
        {
            lstAlumnos.Add(new int[] { a1, a2, a3 });
        }

        public List<int[]> EstudiantesEnRiesgo()
        {
            List<int[]> enRiesgo = new List<int[]>();
            foreach (int[] estudiante in lstAlumnos)
                if (estudiante[1] * 100 / 16 >= 25 || estudiante[2] >= 2)
                    enRiesgo.Add(estudiante);
            return enRiesgo;
        }

        public string Proc()
        {
            List<int[]> l = EstudiantesEnRiesgo();
            string s;
            if (l.Count == 0)
                s = $"Comisión {m_com}: no hay estudiantes en riesgo";
            else if (l.Count == 1)
                s = $"Comisión {m_com}: hay 1 estudiante en riesgo";
            else
                s = $"Comisión {m_com}: hay {l.Count} estudiantes en riesgo";

            foreach (int[] estudiante in l)
                s += $"\n  {estudiante[0]}";
            return s;
        }
    }
}
