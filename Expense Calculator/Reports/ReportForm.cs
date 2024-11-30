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
                DisplayMessage("تم تصفية البيانات بنجاح", Color.White, Color.Green);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DisplayMessage($"خطأ أثناء تحميل البيانات: {ex.Message}", Color.White, Color.DarkRed);
            }
        }


        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                DisplayMessage("لا توجد بيانات للتصدير", Color.White, Color.DarkRed);
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

                        // Add company name
                        var titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                        var companyName = new Paragraph("اسم الشركة", titleFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        pdfDoc.Add(companyName);

                        // Add report title
                        var reportTitle = new Paragraph("تقرير المصروفات", titleFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        pdfDoc.Add(reportTitle);

                        // Add date range
                        var dateFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL);
                        var dateRange = new Paragraph($"الفترة من: {dtpFromDate.Value.ToShortDateString()} إلى: {dtpToDate.Value.ToShortDateString()}", dateFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        pdfDoc.Add(dateRange);

                        pdfDoc.Add(new Paragraph("\n")); // Add spacing

                        // Create a table
                        PdfPTable pdfTable = new PdfPTable(dgvReport.Columns.Count)
                        {
                            WidthPercentage = 100,
                            RunDirection = PdfWriter.RUN_DIRECTION_RTL // For Arabic alignment
                        };

                        // Set column widths
                        pdfTable.SetWidths(new float[] { 2f, 2f, 2f, 2f, 2f }); // Adjust column widths as needed

                        // Add headers
                        var headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont))
                            {
                                BackgroundColor = BaseColor.LIGHT_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5
                            };
                            pdfTable.AddCell(headerCell);
                        }

                        // Add rows
                        var cellFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);
                        decimal overallTotal = 0;
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string value = cell.Value?.ToString() ?? string.Empty;

                                PdfPCell dataCell = new PdfPCell(new Phrase(value, cellFont))
                                {
                                    HorizontalAlignment = Element.ALIGN_RIGHT, // Right-align for Arabic
                                    Padding = 5
                                };
                                pdfTable.AddCell(dataCell);

                                // Calculate overall total for the "الإجمالي اليومي" column
                                if (dgvReport.Columns[cell.ColumnIndex].HeaderText == "الإجمالي اليومي" && decimal.TryParse(value, out decimal numericValue))
                                {
                                    overallTotal += numericValue;
                                }
                            }
                        }

                        // Add overall total row
                        PdfPCell totalLabelCell = new PdfPCell(new Phrase("الإجمالي الكلي:", headerFont))
                        {
                            Colspan = dgvReport.Columns.Count - 1, // Span across all columns except the last
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 5
                        };
                        pdfTable.AddCell(totalLabelCell);

                        PdfPCell totalValueCell = new PdfPCell(new Phrase(overallTotal.ToString("N2"), headerFont))
                        {
                            HorizontalAlignment = Element.ALIGN_RIGHT,
                            Padding = 5
                        };
                        pdfTable.AddCell(totalValueCell);

                        pdfDoc.Add(pdfTable);

                        pdfDoc.Close();
                        stream.Close();
                    }

                    //lblMessage.Text = "تم تصدير التقرير بنجاح";
                    //lblMessage.ForeColor = Color.White;
                    //lblMessage.BackColor = Color.Green;

                    DisplayMessage("تم تصدير التقرير بنجاح", Color.White, Color.Green);

                }
                catch (Exception ex)
                {
                    //lblMessage.Text = $"خطأ أثناء التصدير إلى PDF: {ex.Message}";
                    //lblMessage.ForeColor = Color.White;
                    //lblMessage.BackColor = Color.DarkRed;
                    DisplayMessage($"خطأ أثناء التصدير إلى PDF: {ex.Message}", Color.White, Color.DarkRed);
                }
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
                        var worksheet = workbook.Worksheets.Add("تقرير المصروفات");

                        // Set right-to-left direction
                        worksheet.RightToLeft = true;

                        // Add company name
                        var companyCell = worksheet.Cell(1, 1);
                        companyCell.Value = "اسم الشركة";
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
                                    dgvReport.Columns[j].HeaderText == "مصاريف المطاعم" ||
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
            //// Check if the DataGridView has rows
            //if (dgvReport.Rows.Count == 0)
            //{
            //    lblMessage.Text = "لا توجد بيانات للطباعة"; // Show a message in the label
            //    lblMessage.ForeColor = Color.White;
            //    lblMessage.BackColor = Color.DarkRed;
            //    return;
            //}

            if (dgvReport.Rows.Count == 0)
            {
                DisplayMessage("لا توجد بيانات للطباعة", Color.White, Color.DarkRed);
                return;
            }

            //// Show the print preview dialog
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();

            try
            {
                currentRowIndex = 0; // Reset for new print job
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                DisplayMessage("تم عرض معاينة الطباعة بنجاح", Color.White, Color.Green);
            }
            catch (Exception ex)
            {
                DisplayMessage($"خطأ أثناء الطباعة: {ex.Message}", Color.White, Color.DarkRed);
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
            string companyName = "اسم الشركة";
            e.Graphics.DrawString(companyName, titleFont, brush, new PointF(pageWidth / 2 - e.Graphics.MeasureString(companyName, titleFont).Width / 2, yPosition));
            yPosition += 40;

            // Print report title
            string reportTitle = "تقرير المصروفات";
            e.Graphics.DrawString(reportTitle, titleFont, brush, new PointF(pageWidth / 2 - e.Graphics.MeasureString(reportTitle, titleFont).Width / 2, yPosition));
            yPosition += 40;

            // Print date range
            string dateRange = $"الفترة من: {dtpFromDate.Value.ToShortDateString()} إلى: {dtpToDate.Value.ToShortDateString()}";
            e.Graphics.DrawString(dateRange, contentFont, brush, new PointF(pageWidth / 2 - e.Graphics.MeasureString(dateRange, contentFont).Width / 2, yPosition));
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

            // Print overall total if it's the last page
            if (currentRowIndex >= dgvReport.Rows.Count)
            {
                yPosition += 20;
                string overallTotalText = lblOverallTotal.Text;
                e.Graphics.DrawString(overallTotalText, headerFont, brush, new PointF(pageWidth - margin - e.Graphics.MeasureString(overallTotalText, headerFont).Width, yPosition));

                // Reset currentRowIndex for the next print job
                currentRowIndex = 0;
                e.HasMorePages = false;
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

    }
}