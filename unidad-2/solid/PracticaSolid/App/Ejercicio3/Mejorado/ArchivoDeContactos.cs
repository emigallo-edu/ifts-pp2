namespace App.Ejercicio3.Mejorado
{
    public class ArchivoDeContactos : IRegistroDeContactos
    {
        private readonly string ruta;

        public ArchivoDeContactos(string ruta)
        {
            this.ruta = ruta;
        }

        public void Registrar(Estudiante estudiante, DateTime fecha)
        {
            File.AppendAllText(ruta, $"{fecha:yyyy-MM-dd HH:mm} {estudiante.Legajo} {estudiante.Nombre}{Environment.NewLine}");
        }
    }
}
