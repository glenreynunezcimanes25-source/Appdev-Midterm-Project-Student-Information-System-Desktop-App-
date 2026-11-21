using MySqlConnector;
using SIS.Mobile.Models;

namespace SIS.Mobile.Services;

public class MySqlStudentService : IStudentService
{
    public async Task<List<Student>> GetStudentsAsync(CancellationToken ct = default)
    {
        var list = new List<Student>();
        await using var conn = new MySqlConnection(DbConfig.ConnectionString);
        await conn.OpenAsync(ct);

        await using var cmd = new MySqlCommand(
            "SELECT student_id, full_name, course, year_level FROM students ORDER BY full_name", conn);
        await using var reader = await cmd.ExecuteReaderAsync(ct);

        while (await reader.ReadAsync(ct))
        {
            list.Add(new Student
            {
                StudentId = reader.GetString("student_id"),
                FullName = reader.GetString("full_name"),
                Course = reader.GetString("course"),
                YearLevel = reader.GetString("year_level"),
            });
        }
        return list;
    }
}