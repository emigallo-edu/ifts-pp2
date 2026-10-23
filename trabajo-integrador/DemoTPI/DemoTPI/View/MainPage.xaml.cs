using DemoTPI.VIewModel;

namespace DemoTPI
{
    public partial class MainPage : ContentPage
    {

        private readonly MainViewModel _vm;

        // El ViewModel lo crea el contenedor de dependencias (registrado en MauiProgram)
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            this._vm = vm;
            this.BindingContext = this._vm;
        }

        private void ContentPage_Loaded(object? sender, EventArgs e)
        {
            this._vm.MostrarEstudiantes();
        }
    }
}
