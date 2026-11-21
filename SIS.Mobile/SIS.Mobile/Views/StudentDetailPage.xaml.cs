using SIS.Mobile.Models;

namespace SIS.Mobile.Views;

[QueryProperty(nameof(Student), "Student")]
public partial class StudentDetailPage : ContentPage
{
    private Student? _student;

    public Student? Student
    {
        get => _student;
        set { _student = value; OnPropertyChanged(); }
    }

    public StudentDetailPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}
