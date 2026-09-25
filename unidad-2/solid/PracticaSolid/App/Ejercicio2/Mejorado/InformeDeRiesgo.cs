using System.Text;

namespace App.Ejercicio2.Mejorado
{
    public class InformeDeRiesgo
    {
        public InformeDeRiesgo()
        {
        }

        public string Generar(Comision comision)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Informe de riesgo - Comisión {comision.Nombre}");

            foreach (Estudiante estudiante in comision.Estudiantes)
            {
                double porcentaje = comision.PorcentajeDeInasistencias(estudiante);

                string nivel;
                if (porcentaje >= 25)
                    nivel = "ALTO";
                else if (porcentaje >= 15)
                    nivel = "MEDIO";
                else
                    nivel = "BAJO";

                texto.AppendLine($"{estudiante.Legajo} {estudiante.Nombre}: {porcentaje:0.0}% {nivel}");
            }
            return texto.ToString();
        }
    }
}