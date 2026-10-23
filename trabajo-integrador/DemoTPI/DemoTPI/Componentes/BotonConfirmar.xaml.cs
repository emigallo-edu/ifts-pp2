using System.Windows.Input;

namespace DemoTPI.Componentes
{
    public partial class BotonConfirmar : Button
    {
        // Una BindableProperty es lo que permite usar {Binding ...} sobre la propiedad desde XAML.
        // Se declara un campo estático (el "registro") y una propiedad común que lo envuelve.
        public static readonly BindableProperty ComandoConfirmadoProperty =
            BindableProperty.Create(nameof(ComandoConfirmado), typeof(ICommand), typeof(BotonConfirmar));

        public static readonly BindableProperty PreguntaProperty =
            BindableProperty.Create(nameof(Pregunta), typeof(string), typeof(BotonConfirmar), "¿Está seguro?");

        public ICommand? ComandoConfirmado
        {
            get => (ICommand?)GetValue(ComandoConfirmadoProperty);
            set => SetValue(ComandoConfirmadoProperty, value);
        }

        public string Pregunta
        {
            get => (string)GetValue(PreguntaProperty);
            set => SetValue(PreguntaProperty, value);
        }

        public BotonConfirmar()
        {
            InitializeComponent();
        }

        private async void AlHacerClick(object? sender, EventArgs e)
        {
            Page? pagina = this.Window?.Page;
            if (pagina == null || this.ComandoConfirmado == null)
            {
                return;
            }

            bool confirmado = await pagina.DisplayAlertAsync(this.Text, this.Pregunta, "Sí", "No");
            if (confirmado && this.ComandoConfirmado.CanExecute(this.CommandParameter))
            {
                this.ComandoConfirmado.Execute(this.CommandParameter);
            }
        }
    }
}
