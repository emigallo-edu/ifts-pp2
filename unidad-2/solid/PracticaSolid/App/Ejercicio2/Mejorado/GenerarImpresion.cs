namespace App.Ejercicio2.Mejorado
{
    public class GenerarImpresion
    {
        public void Generar(string nombreArchivo, string contenido)
        {
            File.WriteAllText($"informe-{nombreArchivo}.txt", contenido);
        }
    }
}