namespace App.Ejercicio3.Inicial
{
    public class CanalEmail
    {
        public void EnviarMensaje(Estudiante estudiante, string mensaje)
        {
            Console.WriteLine($"[Email a {estudiante.Email}] {mensaje}");
        }
    }
}
