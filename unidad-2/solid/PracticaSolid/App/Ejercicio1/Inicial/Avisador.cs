namespace App.Ejercicio1.Inicial
{
    public class Avisador
    {
        public void Avisar(Estudiante estudiante, string canal, string mensaje)
        {
            switch (canal)
            {
                case "email":
                    Console.WriteLine($"[Email a {estudiante.Email}] {mensaje}");
                    break;

                case "sms":
                    Console.WriteLine($"[SMS a {estudiante.Telefono}] {mensaje}");
                    break;

                default:
                    throw new ArgumentException($"Canal desconocido: {canal}");
            }
        }
    }
}