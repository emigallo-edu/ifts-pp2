namespace App.Ejercicio3.Mejorado
{
    public class CanalEmailFake : IMensajero
    {
        public void EnviarMensaje(Estudiante estudiante, string mensaje)
        {
            Console.WriteLine($"[Email a {estudiante.Email}] {mensaje}");
        }
    }
}