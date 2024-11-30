using Expense_Calculator.Reports;
using ExpenseCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}