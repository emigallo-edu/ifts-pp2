namespace App.Ejercicio3.Mejorado
{
    public class SeguimientoSemanal
    {
        private const double UmbralDeInasistencias = 25;
        private const string Mensaje = "Notamos que faltaste a varias clases. ¿Podemos hablar?";

        private readonly IMensajero mensajero;
        private readonly IRegistroDeContactos contactos;
        private readonly TimeProvider reloj;

        public SeguimientoSemanal(IMensajero mensajero, IRegistroDeContactos contactos, TimeProvider reloj)
        {
            this.mensajero = mensajero;
            this.contactos = contactos;
            this.reloj = reloj;
        }

        public void Ejecutar(Comision comision)
        {
            foreach (Estudiante estudiante in comision.Estudiantes)
            {
                if (comision.PorcentajeDeInasistencias(estudiante) >= UmbralDeInasistencias)
                {
                    mensajero.EnviarMensaje(estudiante, Mensaje);
                    contactos.Registrar(estudiante, reloj.GetLocalNow().DateTime);
                }
            }
        }
    }
}