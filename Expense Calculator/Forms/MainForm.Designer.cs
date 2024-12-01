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
            this.btnDatabaseSetup = new System.Windows.Forms.Button();
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnReports);
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
            this.btnReports.Image = global::Expense_Calculator.Properties.Resources.Report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(22, 162);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(313, 142);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "التقارير";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnDatabaseSetup
            // 
            this.btnDatabaseSetup.Image = global::Expense_Calculator.Properties.Resources.Add_Database;
            this.btnDatabaseSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabaseSetup.Location = new System.Drawing.Point(22, 312);
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
            this.btnDataEntry.Image = global::Expense_Calculator.Properties.Resources.New_Record;
            this.btnDataEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataEntry.Location = new System.Drawing.Point(22, 12);
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
            this.label1.Text = "صرفيات معمل سما دجلة لصناعة الثرمستون";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حاسبة المصروفات";
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
    }
}

