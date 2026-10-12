using System;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public class  DatabaseConnetion
    {
        private const string SERVER = "Localhost";
        private const string DATABASE = "student_information_system";
        private const string USERNAME = "root";
        private const string PASSWORD = "root";
        private static string ConnectionString => $"Server={SERVER};Database={DATABASE};Uid={USERNAME};Pwd={PASSWORD};";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public bool TestConnection()
        {
            try
            {
                using(var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
//change this if neccesary got it from previous project/activity