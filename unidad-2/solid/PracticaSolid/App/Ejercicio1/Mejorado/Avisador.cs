namespace App.Ejercicio1.Mejorado
{
    public class Avisador
    {
        public void Avisar(Estudiante estudiante, ICanalDeAviso canal, string mensaje)
        {
            canal.Enviar(estudiante, mensaje);
        }
    }
}