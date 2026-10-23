using Dominio.Validaciones;

namespace DemoTPI.Componentes
{
    public partial class CampoTexto : ContentView
    {
        public static readonly BindableProperty TituloProperty =
            BindableProperty.Create(nameof(Titulo), typeof(string), typeof(CampoTexto), string.Empty);

        // TwoWay por defecto: lo que escribe el usuario vuelve al ViewModel
        public static readonly BindableProperty TextoProperty =
            BindableProperty.Create(nameof(Texto), typeof(string), typeof(CampoTexto), string.Empty,
                BindingMode.TwoWay, propertyChanged: AlCambiarValidacion);

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(CampoTexto), string.Empty);

        public static readonly BindableProperty TecladoProperty =
            BindableProperty.Create(nameof(Teclado), typeof(Keyboard), typeof(CampoTexto), Keyboard.Default);

        // Expresión regular que debe cumplir el texto. Vacía = sin validación.
        public static readonly BindableProperty PatronProperty =
            BindableProperty.Create(nameof(Patron), typeof(string), typeof(CampoTexto), string.Empty,
                propertyChanged: AlCambiarValidacion);

        public static readonly BindableProperty MensajeErrorProperty =
            BindableProperty.Create(nameof(MensajeError), typeof(string), typeof(CampoTexto), "Valor inválido");

        public static readonly BindableProperty MostrarErrorProperty =
            BindableProperty.Create(nameof(MostrarError), typeof(bool), typeof(CampoTexto), false);

        public string Titulo
        {
            get => (string)GetValue(TituloProperty);
            set => SetValue(TituloProperty, value);
        }

        public string Texto
        {
            get => (string)GetValue(TextoProperty);
            set => SetValue(TextoProperty, value);
        }

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public Keyboard Teclado
        {
            get => (Keyboard)GetValue(TecladoProperty);
            set => SetValue(TecladoProperty, value);
        }

        public string Patron
        {
            get => (string)GetValue(PatronProperty);
            set => SetValue(PatronProperty, value);
        }

        public string MensajeError
        {
            get => (string)GetValue(MensajeErrorProperty);
            set => SetValue(MensajeErrorProperty, value);
        }

        public bool MostrarError
        {
            get => (bool)GetValue(MostrarErrorProperty);
            set => SetValue(MostrarErrorProperty, value);
        }

        public CampoTexto()
        {
            InitializeComponent();
        }

        private static void AlCambiarValidacion(BindableObject control, object valorAnterior, object valorNuevo)
        {
            ((CampoTexto)control).Validar();
        }

        private void Validar()
        {
            bool esValido = string.IsNullOrEmpty(this.Patron) || Validador.Cumple(this.Texto, this.Patron);
            // Un campo vacío no muestra error: el usuario todavía no escribió nada
            this.MostrarError = !esValido && !string.IsNullOrEmpty(this.Texto);
        }
    }
}
