using SIS.Mobile.Models;

namespace SIS.Mobile.Services;

public interface IStudentService
{
    Task<List<Student>> GetStudentsAsync(CancellationToken ct = default);
}