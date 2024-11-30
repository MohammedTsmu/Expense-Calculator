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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Expense_Calculator.Reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.ShowDialog();

            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string connectionString = AppConfig.GetConnectionString();
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

            //MessageBox.Show($"Filtering data from {fromDate:yyyy-MM-dd} to {toDate:yyyy-MM-dd}", "Debugging");
            lblMessages.Text = $"Filtering data from {fromDate:yyyy-MM-dd} to {toDate:yyyy-MM-dd}";
            string query = @"
        SELECT ExpenseDate AS [التاريخ], 
               MaintenanceExpenditure AS [مصاريف الصيانة], 
               RestaurantExpenditure AS [مصاريف المطاعم], 
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
                            dgvReport.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات للتصدير", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "حفظ التقرير كملف PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Initialize PDF document
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Add title
                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                        Paragraph title = new Paragraph("تقرير المصروفات", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(title);

                        pdfDoc.Add(new Paragraph("\n")); // Add a line break

                        // Add table
                        PdfPTable pdfTable = new PdfPTable(dgvReport.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Add header
                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY; // Add background color for header cells
                            pdfTable.AddCell(cell);
                        }

                        // Add rows
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("تم تصدير التقرير بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء التصدير إلى PDF: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }
    }
}