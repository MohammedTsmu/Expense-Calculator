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
    //public partial class EditDialog : Form
    //{
    //    public EditDialog()
    //    {
    //        InitializeComponent();
    //    }

    //    private void btnSave_Click(object sender, EventArgs e)
    //    {

    //    }
    //}

    public partial class EditDialog : Form
    {
        public decimal MaintenanceExpenditure { get; private set; }
        public decimal RestaurantExpenditure { get; private set; }
        public decimal PurchasesExpenditure { get; private set; }

        public EditDialog(DateTime expenseDate, decimal maintenance, decimal restaurant, decimal purchases)
        {
            InitializeComponent();

            dtpExpenseDate.Value = expenseDate;
            txtMaintenance.Text = maintenance.ToString();
            txtRestaurant.Text = restaurant.ToString();
            txtPurchases.Text = purchases.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMaintenance.Text, out decimal maintenance) &&
                decimal.TryParse(txtRestaurant.Text, out decimal restaurant) &&
                decimal.TryParse(txtPurchases.Text, out decimal purchases))
            {
                MaintenanceExpenditure = maintenance;
                RestaurantExpenditure = restaurant;
                PurchasesExpenditure = purchases;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("يرجى إدخال أرقام صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
