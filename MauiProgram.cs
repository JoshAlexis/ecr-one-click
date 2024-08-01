using EcrOneClick.DI;
using EcrOneClick.ViewModels;
using Microsoft.Extensions.Logging;

namespace EcrOneClick;

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

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MainViewModel>();
        
        var app = builder.Build();
        
        ServiceHelper.Initialize(app.Services);
        
        return app;
    }
}