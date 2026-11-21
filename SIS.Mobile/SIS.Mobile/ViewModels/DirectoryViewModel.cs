using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SIS.Mobile.Models;
using SIS.Mobile.Services;
using SIS.Mobile.Views;

namespace SIS.Mobile.ViewModels;

public partial class DirectoryViewModel : ObservableObject
{
    private readonly IStudentService _service;
    private List<Student> _all = new();

    [ObservableProperty] private string searchText = "";
    [ObservableProperty] private string selectedProgram = "All";
    [ObservableProperty] private bool isBusy;

    [ObservableProperty, NotifyPropertyChangedFor(nameof(HasStatus))]
    private string statusMessage = "";

    public bool HasStatus => !string.IsNullOrEmpty(StatusMessage);
    public ObservableCollection<Student> Students { get; } = new();
    public ObservableCollection<string> Programs { get; } = new();

    public DirectoryViewModel(IStudentService service) => _service = service;

    partial void OnSearchTextChanged(string value) => ApplyFilter();
    partial void OnSelectedProgramChanged(string value) => ApplyFilter();

    [RelayCommand]
    private async Task LoadAsync()
    {
        try
        {
            IsBusy = true;
            StatusMessage = "";
            _all = await _service.GetStudentsAsync();

            Programs.Clear();
            Programs.Add("All");
            foreach (var p in _all.Select(s => s.Course.Trim().ToUpper()).Distinct().OrderBy(p => p))
                Programs.Add(p);

            ApplyFilter();
        }
        catch (Exception)
        {
            StatusMessage = "Can't reach the database. Check that MySQL is running, then pull down to retry.";
        }
        finally
        {
            IsBusy = false;
        }
    }

    [RelayCommand]
    private void SelectProgram(string program) => SelectedProgram = program;

    [RelayCommand]
    private Task OpenDetailAsync(Student student) =>
        Shell.Current.GoToAsync(nameof(StudentDetailPage),
            new Dictionary<string, object> { ["Student"] = student });

    private void ApplyFilter()
    {
        var q = SearchText?.Trim() ?? "";
        var result = _all.Where(s =>
            (SelectedProgram == "All" || s.Course == SelectedProgram) &&
            (q.Length == 0 ||
             s.FullName.Contains(q, StringComparison.OrdinalIgnoreCase) ||
             s.StudentId.Contains(q, StringComparison.OrdinalIgnoreCase)));

        Students.Clear();
        foreach (var s in result) Students.Add(s);
    }
}