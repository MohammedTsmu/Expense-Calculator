using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExpenseCalculator.Helpers;

namespace Expense_Calculator
{
    public partial class DatabaseSetupForm : Form
    {
        public DatabaseSetupForm()
        {
            InitializeComponent();

            AttachClearStatusEvents();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text.Trim();
            string connectionString = $"Server={serverName};Integrated Security=True;";

            DisplayMessage("الرجاء الانتظار, يتم اختبار الاتصال...", Color.DarkGreen, Color.Transparent);
            //lblStatus.Text = "الرجاء الانتظار, يتم اختبار الاتصال...";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DisplayMessage("تم الاتصال بنجاح", Color.DarkGreen, Color.Transparent);
                    //lblStatus.Text = "تم الاتصال بنجاح";
                    //lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                DisplayMessage("فشل الاتصال, " + ex.Message, Color.DarkRed, Color.Transparent);
                //lblStatus.Text = $"فشل الاتصال: {ex.Message}";
                //lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnSaveAndInitialize_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text.Trim();
            string databaseName = txtDatabaseName.Text.Trim();

            AppConfig.ServerName = serverName;
            AppConfig.DatabaseName = databaseName;

            string masterConnectionString = $"Server={serverName};Integrated Security=True;";
            string databaseConnectionString = AppConfig.GetConnectionString();

            try
            {
                // Step 1: Create Database
                using (SqlConnection connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    string createDbQuery = $@"
                IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{databaseName}')
                BEGIN
                    CREATE DATABASE [{databaseName}];
                END";
                    using (SqlCommand command = new SqlCommand(createDbQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Step 2: Create Tables
                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();
                    string createTableQuery = @"
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
                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }


                //lblStatus.Text = "تم إنشاء قاعدة البيانات والجداول بنجاح";
                //lblStatus.ForeColor = System.Drawing.Color.Green;

                DisplayMessage("تم إنشاء قاعدة البيانات والجداول بنجاح", Color.DarkGreen, Color.Transparent);
            }
            catch (Exception ex)
            {
                DisplayMessage("خطأ, " + ex.Message, Color.DarkRed, Color.Transparent);

                //lblStatus.Text = $"خطأ: {ex.Message}";
                //lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ClearStatus(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
        }

        private void AttachClearStatusEvents()
        {
            txtServerName.TextChanged += ClearStatus;
            txtDatabaseName.TextChanged += ClearStatus;
        }

        private async void DisplayMessage(string message, Color textColor, Color backgroundColor, int duration = 3000)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = textColor;
            lblStatus.BackColor = backgroundColor;

            await Task.Delay(duration);

            // Reset to default state
            lblStatus.Text = string.Empty;
            lblStatus.ForeColor = Color.Black;
            lblStatus.BackColor = Color.Transparent;
        }
    }
}