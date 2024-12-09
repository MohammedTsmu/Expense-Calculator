using Expense_Calculator.Forms;
using Expense_Calculator.Reports;
using ExpenseCalculator.Helpers;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Expense_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Add this line to the MainForm constructor or the form's properties in the designer.
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            DataEntryForm dataEntryForm = new DataEntryForm();
            dataEntryForm.ShowDialog();
        }

        private void btnDatabaseSetup_Click(object sender, EventArgs e)
        {
            DatabaseSetupForm databaseSetupForm = new DatabaseSetupForm();
            databaseSetupForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Check if database is configured
            if (string.IsNullOrEmpty(AppConfig.ServerName) || string.IsNullOrEmpty(AppConfig.DatabaseName))
            {
                MessageBox.Show("يرجى إعداد قاعدة البيانات أولاً.", "إعداد قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatabaseSetupForm setupForm = new DatabaseSetupForm();
                setupForm.ShowDialog();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // Check if the backup folder is configured

            BackupForm backupForm = new BackupForm();
            backupForm.ShowDialog();

            string backupFolder = Properties.Settings.Default.BackupFolder;
            if (string.IsNullOrEmpty(backupFolder))
            {
                MessageBox.Show("يرجى تعيين مسار النسخ الاحتياطي أولاً من إعدادات النسخ الاحتياطي.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.EnableAutoBackup)
            {
                string backupFolder = Properties.Settings.Default.BackupFolder;

                if (string.IsNullOrEmpty(backupFolder))
                {
                    MessageBox.Show("لم يتم تعيين مسار النسخ الاحتياطي. يرجى التحقق من الإعدادات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    string databaseName = AppConfig.DatabaseName;
                    string backupFileName = Path.Combine(backupFolder, $"{databaseName}_{DateTime.Now:yyyyMMddHHmmss}.bak");

                    using (SqlConnection connection = new SqlConnection(AppConfig.GetConnectionString()))
                    {
                        connection.Open();
                        string query = $"BACKUP DATABASE [{databaseName}] TO DISK = @BackupFile WITH FORMAT";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BackupFile", backupFileName);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("تم النسخ الاحتياطي بنجاح عند الإغلاق", "نسخ احتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء النسخ الاحتياطي عند الإغلاق: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}