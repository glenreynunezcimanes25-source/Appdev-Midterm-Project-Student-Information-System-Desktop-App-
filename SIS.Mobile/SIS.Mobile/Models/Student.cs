namespace SIS.Mobile.Models;

public class Student
{
    public string StudentId { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Course { get; set; } = "";
    public string YearLevel { get; set; } = "";

    public string Initials => string.Concat(
        FullName.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Take(2).Select(w => w[0])).ToUpper();
}