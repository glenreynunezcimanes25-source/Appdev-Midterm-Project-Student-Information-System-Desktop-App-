
using MySqlConnector;
using SIS.Mobile.Models;

namespace SIS.Mobile.Services
{
    // DATABASE CONFIGURATION
    public static class DbConfig
    {
        private const string Host = "10.0.2.2";
        private const string Database = "student_information_system";
        private const string Username = "root";
        private const string Password = "Glenrey@10282007";

        public static string ConnectionString =>
            $"Server={Host};" +
            "Port=3306;" +
            $"Database={Database};" +
            $"User ID={Username};" +
            $"Password={Password};" +
            "SslMode=None;" +
            "AllowPublicKeyRetrieval=True;" +
            "Connection Timeout=5;";
    }

    // STUDENT SERVICE INTERFACE
    public interface IStudentService
    {
        Task<List<Student>> GetStudentsAsync(
            CancellationToken ct = default);
    }

    // MYSQL STUDENT SERVICE
    public class MySqlStudentService : IStudentService
    {
        public async Task<List<Student>> GetStudentsAsync(
            CancellationToken ct = default)
        {
            var students = new List<Student>();

            await using var connection =
                new MySqlConnection(DbConfig.ConnectionString);

            await connection.OpenAsync(ct);

            const string query = @"
                SELECT
                    student_id,
                    full_name,
                    course,
                    year_level
                FROM students
                ORDER BY full_name;";

            await using var command =
                new MySqlCommand(query, connection);

            await using var reader =
                await command.ExecuteReaderAsync(ct);

            while (await reader.ReadAsync(ct))
            {
                students.Add(new Student
                {
                    StudentId = reader.GetString("student_id"),
                    FullName = reader.GetString("full_name"),
                    Course = reader.GetString("course"),
                    YearLevel = reader.GetString("year_level")
                });
            }

            return students;
        }
    }
}
