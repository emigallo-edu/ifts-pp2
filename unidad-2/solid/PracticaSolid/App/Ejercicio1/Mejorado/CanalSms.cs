namespace App.Ejercicio1.Mejorado
{
    public class CanalSms : ICanalDeAviso
    {
        public void Enviar(Estudiante estudiante, string mensaje)
        {
            Console.WriteLine($"[SMS a {estudiante.Telefono}] {mensaje}");
        }
    }
}