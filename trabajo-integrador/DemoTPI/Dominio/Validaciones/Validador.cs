using System.Text.RegularExpressions;

namespace Dominio.Validaciones
{
    // Los patrones son constantes públicas para poder usarlos tanto desde C#
    // (servicios) como desde XAML (componente CampoTexto) con x:Static.
    public static class Validador
    {
        // usuario@dominio.ext
        //   [\w.+-]+      uno o más caracteres de palabra, punto, más o guion
        //   @             arroba obligatoria
        //   [\w-]+        nombre del dominio
        //   (\.[\w-]+)+   uno o más ".algo" (.com, .com.ar)
        public const string PatronEmail = @"^[\w.+-]+@[\w-]+(\.[\w-]+)+$";

        // Teléfono argentino: 11 4567-8901, 1145678901, +54 9 11 4567 8901
        //   (\+54\s?9?\s?)?   prefijo internacional opcional
        //   \d{2,4}           código de área
        //   [\s-]?            separador opcional (espacio o guion)
        //   \d{3,4}[\s-]?\d{4} número local
        public const string PatronTelefono = @"^(\+54\s?9?\s?)?\d{2,4}[\s-]?\d{3,4}[\s-]?\d{4}$";

        // DNI de 7 u 8 dígitos, con o sin puntos: 12345678, 12.345.678, 1.234.567
        public const string PatronDni = @"^\d{1,2}\.?\d{3}\.?\d{3}$";

        public static bool Cumple(string? texto, string patron)
        {
            return texto != null && Regex.IsMatch(texto.Trim(), patron);
        }

        public static bool EsEmail(string? texto) => Cumple(texto, PatronEmail);
        public static bool EsTelefono(string? texto) => Cumple(texto, PatronTelefono);
        public static bool EsDni(string? texto) => Cumple(texto, PatronDni);
    }
}
