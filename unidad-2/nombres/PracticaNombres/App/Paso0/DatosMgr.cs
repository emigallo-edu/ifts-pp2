namespace App.Paso0
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

        public List<int[]> GetThem()
        {
            List<int[]> list1 = new List<int[]>();
            foreach (int[] x in lstAlumnos)
                if (x[1] * 100 / 16 >= 25 || x[2] >= 2)
                    list1.Add(x);
            return list1;
        }

        public string Proc()
        {
            List<int[]> l = GetThem();
            string s;
            if (l.Count == 0)
                s = $"Comisión {m_com}: no hay estudiantes en riesgo";
            else if (l.Count == 1)
                s = $"Comisión {m_com}: hay 1 estudiante en riesgo";
            else
                s = $"Comisión {m_com}: hay {l.Count} estudiantes en riesgo";

            foreach (int[] x in l)
                s += $"\n  {x[0]}";
            return s;
        }
    }
}
