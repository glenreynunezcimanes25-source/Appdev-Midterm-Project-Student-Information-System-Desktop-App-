using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public static class DatabaseConnection
    {
        // The user only needs to change this password.
        private static readonly string mysqlPassword = "09091862735Tim";// Change this to your MySQL root password

        private static readonly string serverConnection =
            $"Server=localhost;" +
            $"Port=3306;Uid=root;" +
            $"Pwd={mysqlPassword};";

        private static readonly string connectionString =
            serverConnection + "Database=student_information_system;";

        public static void InitializeDatabase()
        {
            // STEP 1: Connect to MySQL WITHOUT selecting a database.
            using (MySqlConnection connection =
                   new MySqlConnection(serverConnection))
            {
                connection.Open();

                // STEP 2: Create the database if it doesn't exist.
                string createDatabase = @"
            CREATE DATABASE IF NOT EXISTS student_information_system
            CHARACTER SET utf8mb4
            COLLATE utf8mb4_unicode_ci;";

                using (MySqlCommand command =
                       new MySqlCommand(createDatabase, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // STEP 3: Connect to the database AFTER creating it.
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                // STEP 4: Create the users table.
                string createUsers = @"
            CREATE TABLE IF NOT EXISTS users
            (
                user_id INT AUTO_INCREMENT PRIMARY KEY,
                username VARCHAR(30) NOT NULL UNIQUE,
                password_hash VARCHAR(255) NOT NULL
            ) ENGINE=InnoDB;";

                using (MySqlCommand command =
                       new MySqlCommand(createUsers, connection))
                {
                    command.ExecuteNonQuery();
                }

                // STEP 5: Create the students table.
                string createStudents = @"
            CREATE TABLE IF NOT EXISTS students
            (
                student_id VARCHAR(50) NOT NULL PRIMARY KEY,
                user_id INT NOT NULL,
                full_name VARCHAR(100) NOT NULL,
                course VARCHAR(100) NOT NULL,
                year_level VARCHAR(20) NOT NULL,
                CONSTRAINT fk_students_users
                    FOREIGN KEY (user_id)
                    REFERENCES users(user_id)
                    ON DELETE CASCADE
            ) ENGINE=InnoDB;";

                using (MySqlCommand command =
                       new MySqlCommand(createStudents, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}