using DemoTPI.VIewModel;

namespace DemoTPI
{
    public partial class MainPage : ContentPage
    {

        private readonly MainViewModel _vm;

        public MainPage()
        {
            InitializeComponent();
            this._vm = new MainViewModel();
            this.BindingContext = this._vm;
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            this._vm.MostrarEstudiantes();
        }
    }
}