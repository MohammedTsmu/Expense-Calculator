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
            this.pnMainForm = new System.Windows.Forms.Panel();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnFill = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessages = new System.Windows.Forms.Label();
            this.pnMainForm.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnFill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMainForm
            // 
            this.pnMainForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnMainForm.Controls.Add(this.btnMainForm);
            this.pnMainForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMainForm.Location = new System.Drawing.Point(929, 0);
            this.pnMainForm.Name = "pnMainForm";
            this.pnMainForm.Size = new System.Drawing.Size(133, 673);
            this.pnMainForm.TabIndex = 9;
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMainForm.Location = new System.Drawing.Point(6, 12);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(126, 124);
            this.btnMainForm.TabIndex = 0;
            this.btnMainForm.Text = "الصفحة الرئيسية";
            this.btnMainForm.UseVisualStyleBackColor = false;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnTop.Controls.Add(this.btnExportExcel);
            this.pnTop.Controls.Add(this.btnExportPdf);
            this.pnTop.Controls.Add(this.btnFilter);
            this.pnTop.Controls.Add(this.dtpToDate);
            this.pnTop.Controls.Add(this.dtpFromDate);
            this.pnTop.Controls.Add(this.lblToDate);
            this.pnTop.Controls.Add(this.lblFromDate);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(929, 184);
            this.pnTop.TabIndex = 14;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(290, 127);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(160, 50);
            this.btnExportExcel.TabIndex = 17;
            this.btnExportExcel.Text = "تصدير إلى Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Location = new System.Drawing.Point(460, 127);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(160, 50);
            this.btnExportPdf.TabIndex = 18;
            this.btnExportPdf.Text = "تصدير إلى PDF";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(626, 127);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(160, 50);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.Text = "عرض التقرير";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(290, 77);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(373, 33);
            this.dtpToDate.TabIndex = 15;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(290, 38);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(373, 33);
            this.dtpFromDate.TabIndex = 16;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(669, 82);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(83, 26);
            this.lblToDate.TabIndex = 13;
            this.lblToDate.Text = "إلى تاريخ";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(669, 43);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(79, 26);
            this.lblFromDate.TabIndex = 14;
            this.lblFromDate.Text = "من تاريخ";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(929, 489);
            this.dgvReport.TabIndex = 15;
            // 
            // pnFill
            // 
            this.pnFill.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnFill.Controls.Add(this.panel1);
            this.pnFill.Controls.Add(this.dgvReport);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 184);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(929, 489);
            this.pnFill.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblMessages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 67);
            this.panel1.TabIndex = 16;
            // 
            // lblMessages
            // 
            this.lblMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessages.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMessages.Location = new System.Drawing.Point(0, 0);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(929, 67);
            this.lblMessages.TabIndex = 14;
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnMainForm);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.pnMainForm.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnFill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMainForm;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessages;
    }
}