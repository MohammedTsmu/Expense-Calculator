using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseCalculator.Helpers;

namespace Expense_Calculator
{
    public partial class DatabaseSetupForm : Form
    {
        public DatabaseSetupForm()
        {
            InitializeComponent();
            AttachClearStatusEvents();

            InitializeFormState();
        }

        // Initialize form state based on database and table existence
        private void InitializeFormState()
        {
            if (CheckDatabaseAndTablesExist())
            {
                DisableForm();
                ShowMessage("قاعدة البيانات والجداول موجودة بالفعل. لا حاجة إلى إعداد جديد.", Color.DarkGreen);
            }
            else
            {
                ShowMessage("قاعدة البيانات والجداول غير موجودة. يرجى الإعداد.", Color.DarkRed);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text.Trim();
            string connectionString = $"Server={serverName};Integrated Security=True;";
            ShowMessage("الرجاء الانتظار، يتم اختبار الاتصال...", Color.DarkGreen);

            ExecuteDatabaseAction(() =>
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
                ShowMessage("تم الاتصال بنجاح", Color.DarkGreen);
            }, ex =>
            {
                ShowMessage($"فشل الاتصال: {ex.Message}", Color.DarkRed);
            });
        }

        private void btnSaveAndInitialize_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text.Trim();
            string databaseName = txtDatabaseName.Text.Trim();

            AppConfig.ServerName = serverName;
            AppConfig.DatabaseName = databaseName;

            string masterConnectionString = $"Server={serverName};Integrated Security=True;";
            string databaseConnectionString = AppConfig.GetConnectionString();

            ExecuteDatabaseAction(() =>
            {
                CreateDatabase(masterConnectionString, databaseName);
                CreateTables(databaseConnectionString);
                ShowMessage("تم إنشاء قاعدة البيانات والجداول بنجاح", Color.DarkGreen);
                DisableForm();
            }, ex =>
            {
                ShowMessage($"خطأ أثناء الإنشاء: {ex.Message}", Color.DarkRed);
            });
        }

        // Check if database and tables exist
        private bool CheckDatabaseAndTablesExist()
        {
            string serverName = txtServerName.Text.Trim();
            string databaseName = txtDatabaseName.Text.Trim();
            string masterConnectionString = $"Server={serverName};Integrated Security=True;";
            string databaseConnectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            return DatabaseExists(masterConnectionString, databaseName) && TablesExist(databaseConnectionString, "Expenses");
        }

        // Check if the database exists
        private bool DatabaseExists(string connectionString, string databaseName)
        {
            return ExecuteDatabaseCheck(() =>
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return (int)command.ExecuteScalar() > 0;
                    }
                }
            });
        }

        // Check if the specified table exists
        private bool TablesExist(string connectionString, string tableName)
        {
            return ExecuteDatabaseCheck(() =>
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return (int)command.ExecuteScalar() > 0;
                    }
                }
            });
        }

        // Create database if not exists
        private void CreateDatabase(string connectionString, string databaseName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"
                    IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{databaseName}')
                    BEGIN
                        CREATE DATABASE [{databaseName}];
                    END";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Create tables if not exists
        private void CreateTables(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    IF NOT EXISTS (
                        SELECT * FROM INFORMATION_SCHEMA.TABLES 
                        WHERE TABLE_NAME = 'Expenses'
                    )
                    BEGIN
                        CREATE TABLE Expenses (
                            ExpenseID INT IDENTITY(1,1) PRIMARY KEY,
                            ExpenseDate DATETIME NOT NULL,
                            MaintenanceExpenditure DECIMAL(18, 2) NOT NULL,
                            RestaurantExpenditure DECIMAL(18, 2) NOT NULL,
                            PurchasesExpenditure DECIMAL(18, 2) NOT NULL
                        );
                    END";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Disable form fields and buttons
        private void DisableForm()
        {
            txtServerName.Enabled = false;
            txtDatabaseName.Enabled = false;
            btnSaveAndInitialize.Enabled = false;
            btnTestConnection.Enabled = false;
        }

        // Show a message to the user
        private async void ShowMessage(string message, Color color, int duration = 3000)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = color;
            await Task.Delay(duration);
            lblStatus.Text = string.Empty;
        }

        // Attach clear status events
        private void AttachClearStatusEvents()
        {
            txtServerName.TextChanged += ClearStatus;
            txtDatabaseName.TextChanged += ClearStatus;
        }

        private void ClearStatus(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
        }

        // Execute a database action safely
        private void ExecuteDatabaseAction(Action action, Action<Exception> errorHandler)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                errorHandler.Invoke(ex);
            }
        }

        // Execute a database check and return a result
        private bool ExecuteDatabaseCheck(Func<bool> check)
        {
            try
            {
                return check.Invoke();
            }
            catch
            {
                return false;
            }
        }
    }
}
