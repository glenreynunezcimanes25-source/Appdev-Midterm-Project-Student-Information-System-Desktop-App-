using SIS.Mobile.ViewModels;

namespace SIS.Mobile.Views;

public partial class DirectoryPage : ContentPage
{
    private readonly DirectoryViewModel _vm;

    public DirectoryPage(DirectoryViewModel vm)
    {
        InitializeComponent();
        BindingContext = _vm = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _vm.LoadCommand.Execute(null);
    }

    private void OnThemeToggle(object? sender, EventArgs e)
    {
        var app = Application.Current!;
        app.UserAppTheme = app.RequestedTheme == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;
        Preferences.Set("theme", app.UserAppTheme.ToString());
    }
}