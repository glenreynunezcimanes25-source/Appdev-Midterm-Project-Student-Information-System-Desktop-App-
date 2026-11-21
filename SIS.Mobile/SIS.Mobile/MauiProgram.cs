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

        // Swap MockStudentService for MySqlStudentService when MySQL is ready
        builder.Services.AddSingleton<IStudentService, MySqlStudentService>();
        builder.Services.AddTransient<DirectoryViewModel>();
        builder.Services.AddTransient<DirectoryPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}