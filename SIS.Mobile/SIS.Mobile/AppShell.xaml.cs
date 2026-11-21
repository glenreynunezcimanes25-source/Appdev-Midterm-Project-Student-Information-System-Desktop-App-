using SIS.Mobile.Views;

namespace SIS.Mobile;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(StudentDetailPage), typeof(StudentDetailPage));
    }
}