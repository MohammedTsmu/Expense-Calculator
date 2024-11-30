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
            DateTime expenseDate = dtpDate.Value;
            decimal maintenance, restaurant, purchases;

            // Validate inputs
            if (!decimal.TryParse(txtMaintenance.Text.Trim(), out maintenance) ||
                !decimal.TryParse(txtRestaurant.Text.Trim(), out restaurant) ||
                !decimal.TryParse(txtPurchases.Text.Trim(), out purchases))
            {
                lblStatus.Text = "يرجى إدخال أرقام صحيحة لجميع الحقول";
                lblStatus.ForeColor = System.Drawing.Color.Red;
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
                        command.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                        command.Parameters.AddWithValue("@Maintenance", maintenance);
                        command.Parameters.AddWithValue("@Restaurant", restaurant);
                        command.Parameters.AddWithValue("@Purchases", purchases);
                        command.ExecuteNonQuery();
                    }
                }

                lblStatus.Text = "تم الحفظ بنجاح";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                ClearFields();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"خطأ أثناء الحفظ: {ex.Message}";
                lblStatus.ForeColor = System.Drawing.Color.Red;
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
            lblStatus.Text = string.Empty;
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btnMainForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
