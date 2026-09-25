namespace App.Ejercicio2.Inicial
{
    public class GenerarImpresion
    {
        public void Generar(string nombreArchivo, string contenido)
        {
            File.WriteAllText($"informe-{nombreArchivo}.txt", contenido);
        }
    }
}