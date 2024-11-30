using Expense_Calculator.Properties;
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
    }
}
