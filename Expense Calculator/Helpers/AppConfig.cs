using Expense_Calculator.Properties;
using System.Data.SqlClient;
//using ExpenseCalculator.Properties; // Replace "ExpenseCalculator" with your actual namespace

namespace ExpenseCalculator.Helpers
{
    public static class AppConfig
    {
        public static string ServerName
        {
            get => Settings.Default.ServerName;
            set
            {
                Settings.Default.ServerName = value;
                Settings.Default.Save();
            }
        }

        public static string DatabaseName
        {
            get => Settings.Default.DatabaseName;
            set
            {
                Settings.Default.DatabaseName = value;
                Settings.Default.Save();
            }
        }

        public static string GetConnectionString()
        {
            return $"Server={ServerName};Database={DatabaseName};Integrated Security=True;";
        }

        public static bool IsDatabaseConfigured()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT 1"; // Simple query to verify connectivity
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteScalar();
                    }
                }
                return true; // Database exists and is accessible
            }
            catch
            {
                return false; // Database is not configured or not accessible
            }
        }
    }
}
