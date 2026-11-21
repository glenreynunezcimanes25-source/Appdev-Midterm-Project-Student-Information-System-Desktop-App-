using SIS.Mobile.Models;

namespace SIS.Mobile.Services;

public class MockStudentService : IStudentService
{
    public async Task<List<Student>> GetStudentsAsync(CancellationToken ct = default)
    {
        await Task.Delay(500, ct);
        return new List<Student>
        {
            new() { StudentId = "2024-0001", FullName = "Clrk BONCODI  ", Course = "BSIT", YearLevel = "2nd Year" },
            new() { StudentId = "2024-0002", FullName = "GLEN REY CIMAN",   Course = "BSCS", YearLevel = "3rd Year" },
            new() { StudentId = "2024-0003", FullName = "PeDRO PENDUKO",    Course = "BSIT", YearLevel = "1st Year" },
            new() { StudentId = "2024-0004", FullName = "jOSHUA Garcia",     Course = "BSIS", YearLevel = "4th Year" },
        };
    }
}