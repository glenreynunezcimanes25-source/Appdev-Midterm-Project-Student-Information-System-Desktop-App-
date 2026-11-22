
using Microsoft.Extensions.Logging;
using SIS.Mobile.Services;
using SIS.Mobile.ViewModels;
using SIS.Mobile.Views;

namespace SIS.Mobile;

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

        // Register MySQL student service
        builder.Services.AddSingleton<IStudentService, MySqlStudentService>();

        // Register application components
        builder.Services.AddTransient<DirectoryViewModel>();
        builder.Services.AddTransient<DirectoryPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
