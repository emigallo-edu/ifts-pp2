namespace App.Ejercicio3.Inicial
{
    public class SeguimientoSemanal
    {
        private readonly CanalEmail _canalEmail;
        private readonly ArchivoDeContactos _archivoDeContactos;

        public SeguimientoSemanal()
        {
            this._canalEmail = new CanalEmail();
            this._archivoDeContactos = new ArchivoDeContactos("contactos.txt");
        }

        public void Ejecutar(Comision comision)
        {
            foreach (Estudiante estudiante in comision.Estudiantes)
            {
                if (comision.PorcentajeDeInasistencias(estudiante) >= 25)
                {
                    this._canalEmail.EnviarMensaje(estudiante, "Notamos que faltaste a varias clases. ¿Podemos hablar?");
                    this._archivoDeContactos.Registrar(estudiante, DateTime.Now);
                }
            }
        }
    }
}