using System.Collections;

namespace DemoTPI.Componentes
{
    public partial class Lista : ContentView
    {
        public static readonly BindableProperty TituloProperty =
            BindableProperty.Create(nameof(Titulo), typeof(string), typeof(Lista), string.Empty);

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(Lista));

        public static readonly BindableProperty ItemTemplateProperty =
            BindableProperty.Create(nameof(ItemTemplate), typeof(DataTemplate), typeof(Lista));

        // TwoWay: la selección del usuario vuelve al ViewModel
        public static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create(nameof(SelectedItem), typeof(object), typeof(Lista), null, BindingMode.TwoWay);

        public static readonly BindableProperty TextoVacioProperty =
            BindableProperty.Create(nameof(TextoVacio), typeof(string), typeof(Lista), "No hay elementos");

        public string Titulo
        {
            get => (string)GetValue(TituloProperty);
            set => SetValue(TituloProperty, value);
        }

        public IEnumerable? ItemsSource
        {
            get => (IEnumerable?)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public DataTemplate? ItemTemplate
        {
            get => (DataTemplate?)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        public object? SelectedItem
        {
            get => GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public string TextoVacio
        {
            get => (string)GetValue(TextoVacioProperty);
            set => SetValue(TextoVacioProperty, value);
        }

        public Lista()
        {
            InitializeComponent();
        }
    }
}
