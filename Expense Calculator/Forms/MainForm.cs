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
            string backupFolder = Properties.Settings.Default.BackupFolder;
            if (string.IsNullOrEmpty(backupFolder))
            {
                MessageBox.Show("يرجى تعيين مسار النسخ الاحتياطي أولاً من إعدادات النسخ الاحتياطي.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BackupForm backupForm = new BackupForm();
            backupForm.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Confirm application close
            var result = MessageBox.Show("هل تريد حقاً إغلاق التطبيق؟", "تأكيد الإغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            // Perform automatic backup on close
            string backupFolder = Properties.Settings.Default.BackupFolder;
            if (!string.IsNullOrEmpty(backupFolder))
            {
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

                    MessageBox.Show("تم النسخ الاحتياطي بنجاح عند إغلاق التطبيق.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء النسخ الاحتياطي: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
