namespace Expense_Calculator.Reports
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnFill = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOverallTotal = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnFill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnTop.Controls.Add(this.btnEdit);
            this.pnTop.Controls.Add(this.btnDelete);
            this.pnTop.Controls.Add(this.btnPrint);
            this.pnTop.Controls.Add(this.btnExportExcel);
            this.pnTop.Controls.Add(this.btnFilter);
            this.pnTop.Controls.Add(this.dtpToDate);
            this.pnTop.Controls.Add(this.dtpFromDate);
            this.pnTop.Controls.Add(this.lblToDate);
            this.pnTop.Controls.Add(this.lblFromDate);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1062, 184);
            this.pnTop.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Image = global::Expense_Calculator.Properties.Resources.Edit_Text_File;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(225, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(199, 50);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Image = global::Expense_Calculator.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(20, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(199, 50);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.Image = global::Expense_Calculator.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(430, 129);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(199, 50);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة التقرير";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportExcel.Image = global::Expense_Calculator.Properties.Resources.Microsoft_Excel_2019;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(637, 129);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(199, 50);
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.Text = "تصدير إلى Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.Image = global::Expense_Calculator.Properties.Resources.View;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(844, 128);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(199, 50);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "عرض التقرير";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpToDate.Location = new System.Drawing.Point(386, 71);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(373, 33);
            this.dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFromDate.Location = new System.Drawing.Point(386, 19);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(373, 33);
            this.dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            this.lblToDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToDate.Image = global::Expense_Calculator.Properties.Resources.Time_Machine;
            this.lblToDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblToDate.Location = new System.Drawing.Point(761, 66);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(144, 47);
            this.lblToDate.TabIndex = 0;
            this.lblToDate.Text = "إلى تاريخ";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromDate.Image = global::Expense_Calculator.Properties.Resources.Time_Machine;
            this.lblFromDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFromDate.Location = new System.Drawing.Point(765, 14);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(140, 47);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "من تاريخ";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1062, 377);
            this.dgvReport.TabIndex = 6;
            // 
            // pnFill
            // 
            this.pnFill.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnFill.Controls.Add(this.dgvReport);
            this.pnFill.Controls.Add(this.panel1);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 184);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(1062, 489);
            this.pnFill.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblOverallTotal);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 112);
            this.panel1.TabIndex = 16;
            // 
            // lblOverallTotal
            // 
            this.lblOverallTotal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOverallTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOverallTotal.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallTotal.ForeColor = System.Drawing.Color.Black;
            this.lblOverallTotal.Location = new System.Drawing.Point(0, 0);
            this.lblOverallTotal.Name = "lblOverallTotal";
            this.lblOverallTotal.Size = new System.Drawing.Size(1062, 72);
            this.lblOverallTotal.TabIndex = 0;
            this.lblOverallTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMessage.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMessage.Location = new System.Drawing.Point(0, 72);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1062, 40);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الصرفيات لمعمل سما دجلة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnFill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblOverallTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}