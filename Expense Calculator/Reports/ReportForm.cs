﻿using System;
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
            // Uncomment this if you want to open the MainForm
            // MainForm mainForm = new MainForm();
            // mainForm.ShowDialog();

            // this.Close();
        }

        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    string connectionString = AppConfig.GetConnectionString();
        //    DateTime fromDate = dtpFromDate.Value.Date;
        //    DateTime toDate = dtpToDate.Value.Date;

        //    string query = @"
        //    SELECT ExpenseDate AS [التاريخ], 
        //           MaintenanceExpenditure AS [مصاريف الصيانة], 
        //           RestaurantExpenditure AS [مصاريف المطاعم], 
        //           PurchasesExpenditure AS [مصاريف المشتريات] 
        //    FROM Expenses
        //    WHERE ExpenseDate >= @FromDate AND ExpenseDate < DATEADD(DAY, 1, @ToDate)
        //    ORDER BY ExpenseDate";

        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@FromDate", fromDate);
        //                command.Parameters.AddWithValue("@ToDate", toDate);

        //                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //                {
        //                    DataTable dataTable = new DataTable();
        //                    adapter.Fill(dataTable);

        //                    // Add a daily total column if it doesn't exist
        //                    if (!dataTable.Columns.Contains("الإجمالي اليومي"))
        //                    {
        //                        dataTable.Columns.Add("الإجمالي اليومي", typeof(decimal));
        //                    }

        //                    // Calculate daily totals
        //                    decimal overallTotal = 0;
        //                    foreach (DataRow row in dataTable.Rows)
        //                    {
        //                        decimal maintenance = Convert.ToDecimal(row["مصاريف الصيانة"]);
        //                        decimal restaurant = Convert.ToDecimal(row["مصاريف المطاعم"]);
        //                        decimal purchases = Convert.ToDecimal(row["مصاريف المشتريات"]);
        //                        decimal dailyTotal = maintenance + restaurant + purchases;
        //                        row["الإجمالي اليومي"] = dailyTotal;
        //                        overallTotal += dailyTotal;
        //                    }

        //                    // Bind the data to the DataGridView
        //                    dgvReport.DataSource = dataTable;

        //                    // Ensure headers are set
        //                    dgvReport.Columns["التاريخ"].HeaderText = "التاريخ";
        //                    dgvReport.Columns["مصاريف الصيانة"].HeaderText = "مصاريف الصيانة";
        //                    dgvReport.Columns["مصاريف المطاعم"].HeaderText = "مصاريف المطاعم";
        //                    dgvReport.Columns["مصاريف المشتريات"].HeaderText = "مصاريف المشتريات";
        //                    dgvReport.Columns["الإجمالي اليومي"].HeaderText = "الإجمالي اليومي";

        //                    // Display the overall total
        //                    lblOverallTotal.Text = $"الإجمالي الكلي: {overallTotal}";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string connectionString = AppConfig.GetConnectionString();
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

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
                                decimal restaurant = Convert.ToDecimal(row["مصاريف المطاعم"]);
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
                                else if (column.Name == "مصاريف المطاعم")
                                    column.HeaderText = "مصاريف المطاعم";
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
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Add title
                        var titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                        var title = new Paragraph("تقرير المصروفات", titleFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        pdfDoc.Add(title);

                        pdfDoc.Add(new Paragraph("\n")); // Line break

                        // Create a table with the number of DataGridView columns
                        PdfPTable pdfTable = new PdfPTable(dgvReport.Columns.Count);
                        pdfTable.WidthPercentage = 100;
                        pdfTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; // For Arabic alignment
                        pdfTable.DefaultCell.Padding = 5;
                        pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                        // Add column headers explicitly
                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            // Fetch HeaderText explicitly
                            string headerText = !string.IsNullOrEmpty(column.HeaderText) ? column.HeaderText : "N/A";

                            PdfPCell cell = new PdfPCell(new Phrase(headerText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)))
                            {
                                BackgroundColor = BaseColor.LIGHT_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };

                            pdfTable.AddCell(cell);
                        }

                        // Add rows to the table
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                            }
                        }

                        // Add the table to the document
                        pdfDoc.Add(pdfTable);

                        // Add overall total to the document
                        pdfDoc.Add(new Paragraph("\n")); // Line break
                        string overallTotalText = lblOverallTotal.Text;
                        Paragraph overallTotalParagraph = new Paragraph(overallTotalText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))
                        {
                            Alignment = Element.ALIGN_RIGHT
                        };
                        pdfDoc.Add(overallTotalParagraph);

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
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات للتصدير", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var worksheet = workbook.Worksheets.Add("تقرير المصروفات");

                        // Add company name
                        var companyCell = worksheet.Cell(1, 1);
                        companyCell.Value = "اسم الشركة";
                        worksheet.Range(1, 1, 1, dgvReport.Columns.Count).Merge();
                        companyCell.Style.Font.Bold = true;
                        companyCell.Style.Font.FontSize = 14;
                        companyCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Add headers
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            var headerCell = worksheet.Cell(2, i + 1);
                            headerCell.Value = dgvReport.Columns[i].HeaderText;
                            headerCell.Style.Font.Bold = true;
                            headerCell.Style.Font.FontSize = 12;
                            headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            headerCell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                            headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        }

                        // Add rows
                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReport.Columns.Count; j++)
                            {
                                var cell = worksheet.Cell(i + 3, j + 1);
                                cell.Value = dgvReport.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                                cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                            }
                        }

                        // Adjust column widths
                        worksheet.Columns().AdjustToContents();

                        // Save the file
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("تم تصدير التقرير بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء التصدير إلى Excel: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}