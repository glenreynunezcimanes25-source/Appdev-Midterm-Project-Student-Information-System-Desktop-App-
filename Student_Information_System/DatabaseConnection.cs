using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=student_information_system;" +
            "Uid=root;" +    
            "Pwd=09091862735Tim;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}