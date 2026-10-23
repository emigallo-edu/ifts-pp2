using DemoTPI.VIewModel;
using Microsoft.Extensions.Logging;
using SQLRepository;

namespace DemoTPI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // La base es un archivo en la carpeta de datos de la app. Cambiar de implementación
            // de persistencia es cambiar esta línea (y la referencia al proyecto).
            string rutaBase = Path.Combine(FileSystem.AppDataDirectory, "demotpi.db");
            builder.Services.AgregarSQLRepository(rutaBase);
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            MauiApp app = builder.Build();
            app.Services.CrearBaseDeDatos();
            return app;
        }
    }
}
