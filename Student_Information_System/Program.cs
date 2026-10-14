using System;
using System.Windows.Forms;

namespace Student_Information_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                DatabaseConnection.InitializeDatabase();
                Application.Run(new LoginForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to MySQL.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}