using Inicial = App.Ejercicio1.Inicial;
using Mejorado = App.Ejercicio1.Mejorado;
using Ejercicio2Inicial = App.Ejercicio2.Inicial;
using Ejercicio2Mejorado = App.Ejercicio2.Mejorado;
using Ejercicio3Inicial = App.Ejercicio3.Inicial;
using Ejercicio3Mejorado = App.Ejercicio3.Mejorado;

public class Progra
{
    static void Main(string[] args)
    {

    }

    private void EjecutarEjercicio1Inicial()
    {
        const string mensaje = "Mañana no hay clase.";

        var estudianteInicial = new Inicial.Estudiante { Email = "ana@ifts.edu.ar", Telefono = "11-5555-1234" };
        var avisadorInicial = new Inicial.Avisador();

        avisadorInicial.Avisar(estudianteInicial, "email", mensaje);
        avisadorInicial.Avisar(estudianteInicial, "sms", mensaje);

        try
        {
            // Agregar WhatsApp obliga a abrir Avisador y sumar un case: la clase no está cerrada a la modificación.
            avisadorInicial.Avisar(estudianteInicial, "whatsapp", mensaje);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Falla en ejecución: {ex.Message}");
        }
    }
    
    private void EjecutarEjercicio1Mejorado()
    {
        const string mensaje = "Mañana no hay clase.";
        var estudianteMejorado = new Mejorado.Estudiante { Email = "ana@ifts.edu.ar", Telefono = "11-5555-1234" };
        var avisadorMejorado = new Mejorado.Avisador();

        avisadorMejorado.Avisar(estudianteMejorado, new Mejorado.CanalEmail(), mensaje);
        avisadorMejorado.Avisar(estudianteMejorado, new Mejorado.CanalSms(), mensaje);

        // WhatsApp se agrega con una clase nueva, declarada acá abajo, sin tocar una sola línea de Avisador.
        //   avisadorMejorado.Avisar(estudianteMejorado, new CanalWhatsApp(), mensaje);
    }

    private void EjecutarEjercicio2Inicial()
    {
        var ana = new Ejercicio2Inicial.Estudiante("1001", "Ana");
        var luis = new Ejercicio2Inicial.Estudiante("1002", "Luis");
        var comision = new Ejercicio2Inicial.Comision("K2051", 20);
        comision.Inscribir(ana);
        comision.Inscribir(luis);
        comision.RegistrarInasistencias(ana, 6);
        comision.RegistrarInasistencias(luis, 3);

        // Calcular, clasificar, redactar y guardar van juntos: la única forma de ver el resultado es leer el archivo.
        new Ejercicio2Inicial.InformeDeRiesgo().Generar(comision);
        Console.Write(File.ReadAllText("informe-K2051.txt"));
    }

    private void EjecutarEjercicio2Mejorado()
    {
        var ana = new Ejercicio2Mejorado.Estudiante("1001", "Ana");
        var luis = new Ejercicio2Mejorado.Estudiante("1002", "Luis");
        var comision = new Ejercicio2Mejorado.Comision("K2051", 20);
        comision.Inscribir(ana);
        comision.Inscribir(luis);
        comision.RegistrarInasistencias(ana, 6);
        comision.RegistrarInasistencias(luis, 3);

        new Ejercicio2Mejorado.GenerarInformeParaImprimir().Generar(comision);
    }

    private void EjecutarEjercicio3Inicial()
    {
        var ana = new Ejercicio3Inicial.Estudiante("1001", "Ana", "ana@ifts.edu.ar");
        var luis = new Ejercicio3Inicial.Estudiante("1002", "Luis", "luis@ifts.edu.ar");
        var comision = new Ejercicio3Inicial.Comision("K2051", 20);
        comision.Inscribir(ana);
        comision.Inscribir(luis);
        comision.RegistrarInasistencias(ana, 6);
        comision.RegistrarInasistencias(luis, 3);

        // SeguimientoSemanal crea adentro el email, el archivo y la hora: no hay forma de ejecutarlo sin mandar mails reales y escribir contactos.txt.
        new Ejercicio3Inicial.SeguimientoSemanal().Ejecutar(comision);
    }

    private void EjecutarEjercicio3Mejorado()
    {
        var ana = new Ejercicio3Mejorado.Estudiante("1001", "Ana", "ana@ifts.edu.ar");
        var luis = new Ejercicio3Mejorado.Estudiante("1002", "Luis", "luis@ifts.edu.ar");
        var comision = new Ejercicio3Mejorado.Comision("K2051", 20);
        comision.Inscribir(ana);
        comision.Inscribir(luis);
        comision.RegistrarInasistencias(ana, 6);
        comision.RegistrarInasistencias(luis, 3);

        // Las dependencias se reciben desde afuera: cambiar el canal, el registro o el reloj no toca SeguimientoSemanal.
        new Ejercicio3Mejorado.SeguimientoSemanal(
            new Ejercicio3Mejorado.CanalEmailFake(),
            new Ejercicio3Mejorado.ArchivoDeContactos("contactos.txt"),
            TimeProvider.System).Ejecutar(comision);
    }
}