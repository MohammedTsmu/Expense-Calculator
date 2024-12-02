namespace Expense_Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnDatabaseSetup = new System.Windows.Forms.Button();
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnDatabaseSetup);
            this.panel1.Controls.Add(this.btnDataEntry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(715, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 673);
            this.panel1.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Image = global::Expense_Calculator.Properties.Resources.Report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(17, 186);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(313, 142);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "التقارير";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.Image = global::Expense_Calculator.Properties.Resources.Data_Backup;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(17, 344);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(313, 142);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "نسخ احتياطي";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDatabaseSetup
            // 
            this.btnDatabaseSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatabaseSetup.Image = global::Expense_Calculator.Properties.Resources.Add_Database;
            this.btnDatabaseSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabaseSetup.Location = new System.Drawing.Point(17, 502);
            this.btnDatabaseSetup.Name = "btnDatabaseSetup";
            this.btnDatabaseSetup.Size = new System.Drawing.Size(313, 142);
            this.btnDatabaseSetup.TabIndex = 2;
            this.btnDatabaseSetup.Text = "انشاء قاعدة بيانات";
            this.btnDatabaseSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatabaseSetup.UseVisualStyleBackColor = true;
            this.btnDatabaseSetup.Click += new System.EventHandler(this.btnDatabaseSetup_Click);
            // 
            // btnDataEntry
            // 
            this.btnDataEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDataEntry.Image = global::Expense_Calculator.Properties.Resources.New_Record;
            this.btnDataEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataEntry.Location = new System.Drawing.Point(17, 28);
            this.btnDataEntry.Name = "btnDataEntry";
            this.btnDataEntry.Size = new System.Drawing.Size(313, 142);
            this.btnDataEntry.TabIndex = 0;
            this.btnDataEntry.Text = "أدخال سجل جديد";
            this.btnDataEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDataEntry.UseVisualStyleBackColor = true;
            this.btnDataEntry.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LBC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 157);
            this.label1.TabIndex = 2;
            this.label1.Text = "صرفيات معمل سما دجلة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Expense_Calculator.Properties.Resources.Money_PNG_512;
            this.pictureBox1.Location = new System.Drawing.Point(234, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 601);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(715, 72);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "جميع الحقوق محفوظة حاسبة الصرفيات © 2024\r\nExpense Calculator v1.0.0\r\n";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حاسبة الصرفيات/ v1.0.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDatabaseSetup;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblStatus;
    }
}

