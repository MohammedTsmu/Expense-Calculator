using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ExpenseCalculator.Helpers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Expense_Calculator.Reports
{
    public partial class ReportForm : Form
    {
        // Track the current row index globally
        private int currentRowIndex = 0;

        public ReportForm()
        {
            InitializeComponent();
            InitializePrintDocument();

            // In the form's Load event or Designer
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false; // Allow selecting only one row at a time
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            // Uncomment this if you want to open the MainForm
            // MainForm mainForm = new MainForm();
            // mainForm.ShowDialog();

            // this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string connectionString = AppConfig.GetConnectionString();
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

            string query = @"
        SELECT ExpenseDate AS [التاريخ], 
               MaintenanceExpenditure AS [مصاريف الصيانة], 
               RestaurantExpenditure AS [مصاريف المطعم], 
               PurchasesExpenditure AS [مصاريف المشتريات] 
        FROM Expenses
        WHERE ExpenseDate >= @FromDate AND ExpenseDate < DATEADD(DAY, 1, @ToDate)
        ORDER BY ExpenseDate";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FromDate", fromDate);
                        command.Parameters.AddWithValue("@ToDate", toDate);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Add a daily total column if it doesn't exist
                            if (!dataTable.Columns.Contains("الإجمالي اليومي"))
                            {
                                dataTable.Columns.Add("الإجمالي اليومي", typeof(decimal));
                            }

                            // Calculate daily totals
                            decimal overallTotal = 0;
                            foreach (DataRow row in dataTable.Rows)
                            {
                                decimal maintenance = Convert.ToDecimal(row["مصاريف الصيانة"]);
                                decimal restaurant = Convert.ToDecimal(row["مصاريف المطعم"]);
                                decimal purchases = Convert.ToDecimal(row["مصاريف المشتريات"]);
                                decimal dailyTotal = maintenance + restaurant + purchases;
                                row["الإجمالي اليومي"] = dailyTotal;
                                overallTotal += dailyTotal;
                            }

                            // Bind the data to the DataGridView
                            dgvReport.DataSource = dataTable;

                            // Explicitly set column headers
                            foreach (DataGridViewColumn column in dgvReport.Columns)
                            {
                                if (column.Name == "التاريخ")
                                    column.HeaderText = "التاريخ";
                                else if (column.Name == "مصاريف الصيانة")
                                    column.HeaderText = "مصاريف الصيانة";
                                else if (column.Name == "مصاريف المطعم")
                                    column.HeaderText = "مصاريف المطعم";
                                else if (column.Name == "مصاريف المشتريات")
                                    column.HeaderText = "مصاريف المشتريات";
                                else if (column.Name == "الإجمالي اليومي")
                                    column.HeaderText = "الإجمالي اليومي";
                            }

                            // Display the overall total
                            lblOverallTotal.Text = $"الإجمالي الكلي: {overallTotal}";
                        }
                    }
                }
                DisplayMessage("تم تصفية البيانات بنجاح", Color.White, Color.Green);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DisplayMessage($"خطأ أثناء تحميل البيانات: {ex.Message}", Color.White, Color.DarkRed);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                DisplayMessage("لا توجد بيانات للتصدير", Color.White, Color.DarkRed);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "حفظ التقرير كملف Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("تقرير الصرفيات");

                        // Set right-to-left direction
                        worksheet.RightToLeft = true;

                        // Add company name
                        var companyCell = worksheet.Cell(1, 1);
                        companyCell.Value = "معمل سما دجلة لصناعة الثرمستون";
                        worksheet.Range(1, 1, 1, dgvReport.Columns.Count).Merge();
                        companyCell.Style.Font.Bold = true;
                        companyCell.Style.Font.FontSize = 16;
                        companyCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Add date range
                        var dateRangeCell = worksheet.Cell(2, 1);
                        dateRangeCell.Value = $"الفترة من: {dtpFromDate.Value.ToShortDateString()} إلى: {dtpToDate.Value.ToShortDateString()}";
                        worksheet.Range(2, 1, 2, dgvReport.Columns.Count).Merge();
                        dateRangeCell.Style.Font.Bold = true;
                        dateRangeCell.Style.Font.FontSize = 14;
                        dateRangeCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Add headers
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            var headerCell = worksheet.Cell(3, i + 1);
                            headerCell.Value = dgvReport.Columns[i].HeaderText;
                            headerCell.Style.Font.Bold = true;
                            headerCell.Style.Font.FontSize = 12;
                            headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            headerCell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                            headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        }

                        // Add rows
                        decimal overallTotal = 0;
                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReport.Columns.Count; j++)
                            {
                                var cell = worksheet.Cell(i + 4, j + 1);
                                var value = dgvReport.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                                // Check if the column contains numeric data
                                if (dgvReport.Columns[j].HeaderText == "مصاريف الصيانة" ||
                                    dgvReport.Columns[j].HeaderText == "مصاريف المطعم" ||
                                    dgvReport.Columns[j].HeaderText == "مصاريف المشتريات" ||
                                    dgvReport.Columns[j].HeaderText == "الإجمالي اليومي")
                                {
                                    if (decimal.TryParse(value, out decimal numericValue))
                                    {
                                        cell.Value = numericValue; // Store as numeric
                                        cell.Style.NumberFormat.Format = "#,##0.00"; // Format as number with two decimal places
                                        if (dgvReport.Columns[j].HeaderText == "الإجمالي اليومي")
                                        {
                                            overallTotal += numericValue; // Calculate total directly
                                        }
                                    }
                                    else
                                    {
                                        cell.Value = value; // Fallback for non-numeric data
                                    }
                                }
                                else
                                {
                                    cell.Value = value; // Store as string
                                }

                                cell.Style.Font.FontSize = 11;
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                                cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                            }
                        }

                        // Add overall total row
                        var totalRow = worksheet.Cell(dgvReport.Rows.Count + 4, 1);
                        totalRow.Value = "الإجمالي الكلي:";
                        worksheet.Range(dgvReport.Rows.Count + 4, 1, dgvReport.Rows.Count + 4, dgvReport.Columns.Count - 1).Merge();
                        totalRow.Style.Font.Bold = true;
                        totalRow.Style.Font.FontSize = 12;
                        totalRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        var totalCell = worksheet.Cell(dgvReport.Rows.Count + 4, dgvReport.Columns.Count);
                        totalCell.Value = overallTotal; // Store as numeric
                        totalCell.Style.Font.Bold = true;
                        totalCell.Style.Font.FontSize = 12;
                        totalCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                        totalCell.Style.NumberFormat.Format = "#,##0.00"; // Format as number with two decimal places

                        // Adjust column widths
                        worksheet.Columns().AdjustToContents();

                        // Save the file
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    //lblMessage.Text = "تم تصدير التقرير بنجاح";
                    //lblMessage.ForeColor = Color.White;
                    //lblMessage.BackColor = Color.Green;
                    //lblMessage.Text = "تم تصدير التقرير بنجاح.";
                    //lblMessage.ForeColor = Color.Green;

                    DisplayMessage("تم تصدير التقرير بنجاح", Color.White, Color.Green);


                }
                catch (Exception ex)
                {
                    //lblMessage.Text = $"خطأ أثناء التصدير إلى Excel: {ex.Message}";
                    //lblMessage.ForeColor = Color.White;
                    //lblMessage.BackColor = Color.DarkRed;
                    DisplayMessage($"خطأ أثناء التصدير إلى Excel: {ex.Message}", Color.White, Color.DarkRed);

                }
            }
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    printPreviewDialog1.Document = printDocument1;
        //    printPreviewDialog1.ShowDialog();
        //}

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                DisplayMessage("لا توجد بيانات للطباعة", Color.White, Color.DarkRed);
                return;
            }

            try
            {
                // Check if a default printer is saved in settings
                string defaultPrinter = Properties.Settings.Default.DefaultPrinter;
                if (!string.IsNullOrEmpty(defaultPrinter))
                {
                    // Use the saved default printer
                    printDocument1.PrinterSettings.PrinterName = defaultPrinter;
                }

                // Show the PrintDialog to allow the user to select a printer
                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument1,
                    AllowCurrentPage = true,
                    AllowSomePages = true
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the selected printer as the default printer
                    Properties.Settings.Default.DefaultPrinter = printDocument1.PrinterSettings.PrinterName;
                    Properties.Settings.Default.Save();

                    // Reset for new print job
                    currentRowIndex = 0;
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    DisplayMessage("تم عرض معاينة الطباعة بنجاح", Color.White, Color.Green);
                }
                else
                {
                    DisplayMessage("تم إلغاء الطباعة", Color.White, Color.Orange);
                }
            }
            catch (Exception ex)
            {
                DisplayMessage($"خطأ أثناء الطباعة: {ex.Message}", Color.White, Color.DarkRed);
            }
        }

        private void btnSetDefaultPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the selected printer as the default printer
                Properties.Settings.Default.DefaultPrinter = printDialog.PrinterSettings.PrinterName;
                Properties.Settings.Default.Save();

                lblMessage.Text = $"تم تعيين الطابعة الافتراضية: {printDialog.PrinterSettings.PrinterName}";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "تم إلغاء تحديد الطابعة الافتراضية";
                lblMessage.ForeColor = Color.Orange;
            }
        }

        private void InitializePrintDocument()
        {
            string defaultPrinter = Properties.Settings.Default.DefaultPrinter;

            if (!string.IsNullOrEmpty(defaultPrinter))
            {
                printDocument1.PrinterSettings.PrinterName = defaultPrinter;
            }
        }

        //private int currentRowIndex = 0; // Add this as a class-level variable to track progress.

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Fonts and brushes
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 10);
            Brush brush = Brushes.Black;
            Pen blackPen = new Pen(Color.Black, 1);

            int margin = 50; // Margins
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;
            int yPosition = margin; // Starting y position

            // Reverse column order for RTL
            var columns = dgvReport.Columns.Cast<DataGridViewColumn>().OrderByDescending(c =>
            {
                if (c.HeaderText == "التاريخ") return int.MaxValue; // Keep datetime as the rightmost column
                if (c.HeaderText == "الإجمالي اليومي") return 0; // Move total to the leftmost
                return 1;
            }).ToList();

            // Print company name
            string companyName = "معمل سما دجلة لصناعة الثرمستون";
            e.Graphics.DrawString(companyName, titleFont, brush, new PointF(pageWidth / 2 - e.Graphics.MeasureString(companyName, titleFont).Width / 2, yPosition));
            yPosition += 40;

            // Print report title
            string reportTitle = "تقرير الصرفيات";
            e.Graphics.DrawString(reportTitle, titleFont, brush, new PointF(pageWidth / 2 - e.Graphics.MeasureString(reportTitle, titleFont).Width / 2, yPosition));
            yPosition += 40;

            // Print date range
            string dateRange = $"الفترة من: {dtpFromDate.Value.ToShortDateString()} إلى: {dtpToDate.Value.ToShortDateString()}";
            e.Graphics.DrawString(dateRange, contentFont, brush, new PointF(pageWidth / 2 - e.Graphics.MeasureString(dateRange, contentFont).Width / 2, yPosition));
            yPosition += 40;

            // Print overall total at the top
            string overallTotalText = lblOverallTotal.Text;
            e.Graphics.DrawString(overallTotalText, headerFont, brush, new PointF(pageWidth / 2 - e.Graphics.MeasureString(overallTotalText, headerFont).Width / 2, yPosition));
            yPosition += 40;

            // Draw table headers
            int columnWidth = (pageWidth - 2 * margin) / columns.Count;
            int headerHeight = 30;

            // Header background
            e.Graphics.FillRectangle(Brushes.LightGray, margin, yPosition, pageWidth - 2 * margin, headerHeight);

            foreach (var column in columns)
            {
                string headerText = column.HeaderText;
                int columnIndex = columns.IndexOf(column);
                int xPosition = pageWidth - margin - (columnIndex + 1) * columnWidth; // Adjust for RTL

                e.Graphics.DrawRectangle(blackPen, xPosition, yPosition, columnWidth, headerHeight);
                e.Graphics.DrawString(headerText, headerFont, brush, new RectangleF(xPosition, yPosition, columnWidth, headerHeight), new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }
            yPosition += headerHeight;

            // Draw table rows
            while (currentRowIndex < dgvReport.Rows.Count)
            {
                DataGridViewRow row = dgvReport.Rows[currentRowIndex];

                // Skip the default "new row"
                if (row.IsNewRow)
                {
                    currentRowIndex++;
                    continue;
                }

                if (yPosition + 20 > pageHeight - margin)
                {
                    e.HasMorePages = true; // Add another page if content doesn't fit
                    return;
                }

                int rowHeight = 20; // Default row height
                List<int> cellHeights = new List<int>(); // Keep track of cell heights for dynamic adjustment

                foreach (var column in columns)
                {
                    string cellValue = row.Cells[column.Index].Value?.ToString() ?? string.Empty;
                    int columnIndex = columns.IndexOf(column);
                    int xPosition = pageWidth - margin - (columnIndex + 1) * columnWidth; // Adjust for RTL

                    // Measure text height for dynamic cell adjustment
                    SizeF textSize = e.Graphics.MeasureString(cellValue, contentFont, columnWidth);
                    int dynamicHeight = (int)textSize.Height + 10; // Add padding
                    cellHeights.Add(dynamicHeight);
                }

                // Set rowHeight to the maximum height of all cells in the row
                rowHeight = cellHeights.Max();

                // Draw cells in the row
                foreach (var column in columns)
                {
                    string cellValue = row.Cells[column.Index].Value?.ToString() ?? string.Empty;
                    int columnIndex = columns.IndexOf(column);
                    int xPosition = pageWidth - margin - (columnIndex + 1) * columnWidth; // Adjust for RTL

                    // Draw cell border
                    e.Graphics.DrawRectangle(blackPen, xPosition, yPosition, columnWidth, rowHeight);

                    // Draw cell content
                    e.Graphics.DrawString(cellValue, contentFont, brush, new RectangleF(xPosition, yPosition, columnWidth, rowHeight), new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
                }

                yPosition += rowHeight; // Move to the next row
                currentRowIndex++; // Increment row index
            }

            // Reset currentRowIndex for subsequent print actions
            if (currentRowIndex >= dgvReport.Rows.Count)
            {
                currentRowIndex = 0;
                e.HasMorePages = false; // No more pages to print
            }
        }

        private async void DisplayMessage(string message, Color textColor, Color backgroundColor, int duration = 3000)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = textColor;
            lblMessage.BackColor = backgroundColor;

            await Task.Delay(duration);

            // Reset to default state
            lblMessage.Text = string.Empty;
            lblMessage.ForeColor = Color.Black;
            lblMessage.BackColor = Color.Gray;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReport.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى تحديد سجل لتعديله", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvReport.SelectedRows[0];
            int rowIndex = selectedRow.Index;

            // Retrieve data from the selected row
            DateTime originalExpenseDate = Convert.ToDateTime(selectedRow.Cells["التاريخ"].Value); // Original date
            decimal maintenance = Convert.ToDecimal(selectedRow.Cells["مصاريف الصيانة"].Value);
            decimal restaurant = Convert.ToDecimal(selectedRow.Cells["مصاريف المطعم"].Value);
            decimal purchases = Convert.ToDecimal(selectedRow.Cells["مصاريف المشتريات"].Value);

            // Show an input dialog or custom form for editing
            using (EditDialog editDialog = new EditDialog(originalExpenseDate, maintenance, restaurant, purchases))
            {
                if (editDialog.ShowDialog() == DialogResult.OK)
                {
                    DateTime updatedExpenseDate = editDialog.ExpenseDate;

                    // Update the database
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(AppConfig.GetConnectionString()))
                        {
                            connection.Open();
                            string query = @"
                        UPDATE Expenses
                        SET ExpenseDate = @UpdatedExpenseDate,
                            MaintenanceExpenditure = @Maintenance,
                            RestaurantExpenditure = @Restaurant,
                            PurchasesExpenditure = @Purchases
                        WHERE ExpenseDate = @OriginalExpenseDate";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@UpdatedExpenseDate", updatedExpenseDate); // Save updated date and time
                                command.Parameters.AddWithValue("@Maintenance", editDialog.MaintenanceExpenditure);
                                command.Parameters.AddWithValue("@Restaurant", editDialog.RestaurantExpenditure);
                                command.Parameters.AddWithValue("@Purchases", editDialog.PurchasesExpenditure);
                                command.Parameters.AddWithValue("@OriginalExpenseDate", originalExpenseDate); // Match original record

                                command.ExecuteNonQuery();
                            }
                        }

                        // Update the DataGridView
                        dgvReport.Rows[rowIndex].Cells["التاريخ"].Value = updatedExpenseDate; // Update date with time
                        dgvReport.Rows[rowIndex].Cells["مصاريف الصيانة"].Value = editDialog.MaintenanceExpenditure;
                        dgvReport.Rows[rowIndex].Cells["مصاريف المطعم"].Value = editDialog.RestaurantExpenditure;
                        dgvReport.Rows[rowIndex].Cells["مصاريف المشتريات"].Value = editDialog.PurchasesExpenditure;

                        MessageBox.Show("تم تعديل السجل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطأ أثناء تعديل السجل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReport.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى تحديد سجل لحذفه", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا السجل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dgvReport.SelectedRows[0];
                DateTime expenseDate = Convert.ToDateTime(selectedRow.Cells["التاريخ"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(AppConfig.GetConnectionString()))
                    {
                        connection.Open();
                        string query = "DELETE FROM Expenses WHERE ExpenseDate = @ExpenseDate";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Remove the row from DataGridView
                    dgvReport.Rows.Remove(selectedRow);
                    MessageBox.Show("تم حذف السجل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء حذف السجل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}