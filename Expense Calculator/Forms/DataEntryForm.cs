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
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = AppConfig.GetConnectionString();
            DateTime expenseDate = dtpDate.Value; // Include time

            decimal maintenance, restaurant, purchases;

            // Validate inputs
            if (!decimal.TryParse(txtMaintenance.Text.Trim(), out maintenance) ||
                !decimal.TryParse(txtRestaurant.Text.Trim(), out restaurant) ||
                !decimal.TryParse(txtPurchases.Text.Trim(), out purchases))
            {
                DisplayMessage("يرجى إدخال أرقام صحيحة لجميع الحقول", Color.DarkRed, Color.Transparent);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                INSERT INTO Expenses (ExpenseDate, MaintenanceExpenditure, RestaurantExpenditure, PurchasesExpenditure)
                VALUES (@ExpenseDate, @Maintenance, @Restaurant, @Purchases)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExpenseDate", expenseDate); // Store date with time
                        command.Parameters.AddWithValue("@Maintenance", maintenance);
                        command.Parameters.AddWithValue("@Restaurant", restaurant);
                        command.Parameters.AddWithValue("@Purchases", purchases);
                        command.ExecuteNonQuery();
                    }
                }

                DisplayMessage("تم الحفظ بنجاح", Color.DarkGreen, Color.Transparent);
                ClearFields();
            }
            catch (Exception ex)
            {
                DisplayMessage($"خطأ أثناء الحفظ: {ex.Message}", Color.DarkRed, Color.Transparent);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            dtpDate.Value = DateTime.Now;
            txtMaintenance.Clear();
            txtRestaurant.Clear();
            txtPurchases.Clear();
            //lblStatus.Text = string.Empty;
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
