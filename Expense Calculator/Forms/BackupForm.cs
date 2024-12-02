using ExpenseCalculator.Helpers;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Calculator.Forms
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void btnBackupNow_Click(object sender, EventArgs e)
        {
            string backupFolder = Properties.Settings.Default.BackupFolder;

            if (string.IsNullOrEmpty(backupFolder))
            {
                DisplayMessage("الرجاء تعيين مسار النسخ الاحتياطي أولاً", Color.White, Color.DarkRed);
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

                DisplayMessage("تم النسخ الاحتياطي بنجاح", Color.White, Color.Green);
            }
            catch (Exception ex)
            {
                DisplayMessage($"خطأ أثناء النسخ الاحتياطي: {ex.Message}", Color.White, Color.DarkRed);
            }
        }

        private void btnConfigureBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.BackupFolder = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();

                    DisplayMessage($"تم تعيين مسار النسخ الاحتياطي إلى: {folderDialog.SelectedPath}", Color.White, Color.Green);
                }
            }
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

        private void BackupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackupFolder))
            {
                btnBackupNow_Click(null, null); // Trigger backup on form close
            }
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Backup Files (*.bak)|*.bak",
                Title = "حدد ملف النسخة الاحتياطية"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupFilePath = openFileDialog.FileName;

                try
                {
                    string databaseName = AppConfig.DatabaseName;

                    // Connect to the master database
                    using (SqlConnection connection = new SqlConnection(AppConfig.GetConnectionString().Replace($"Database={databaseName};", "Database=master;")))
                    {
                        connection.Open();

                        // Set the target database to single-user mode to allow restoration
                        string setSingleUserQuery = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        using (SqlCommand singleUserCommand = new SqlCommand(setSingleUserQuery, connection))
                        {
                            singleUserCommand.ExecuteNonQuery();
                        }

                        // Restore the database
                        string restoreQuery = $@"
                    RESTORE DATABASE [{databaseName}] 
                    FROM DISK = @BackupFile 
                    WITH REPLACE";
                        using (SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection))
                        {
                            restoreCommand.Parameters.AddWithValue("@BackupFile", backupFilePath);
                            restoreCommand.ExecuteNonQuery();
                        }

                        // Set the database back to multi-user mode
                        string setMultiUserQuery = $"ALTER DATABASE [{databaseName}] SET MULTI_USER";
                        using (SqlCommand multiUserCommand = new SqlCommand(setMultiUserQuery, connection))
                        {
                            multiUserCommand.ExecuteNonQuery();
                        }
                    }

                    DisplayMessage("تم استعادة النسخة الاحتياطية بنجاح", Color.White, Color.Green);
                }
                catch (Exception ex)
                {
                    DisplayMessage($"خطأ أثناء استعادة النسخة الاحتياطية: {ex.Message}", Color.White, Color.DarkRed);
                }
            }
        }


    }
}