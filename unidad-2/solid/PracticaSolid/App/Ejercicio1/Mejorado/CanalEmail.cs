namespace App.Ejercicio1.Mejorado
{
    public class CanalEmail : ICanalDeAviso
    {
        public void Enviar(Estudiante estudiante, string mensaje)
        {
            Console.WriteLine($"[Email a {estudiante.Email}] {mensaje}");
        }
    }
}