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
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatabaseSetup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDataEntry
            // 
            this.btnDataEntry.Location = new System.Drawing.Point(80, 64);
            this.btnDataEntry.Name = "btnDataEntry";
            this.btnDataEntry.Size = new System.Drawing.Size(140, 84);
            this.btnDataEntry.TabIndex = 0;
            this.btnDataEntry.Text = "أدخال سجل جديد";
            this.btnDataEntry.UseVisualStyleBackColor = true;
            this.btnDataEntry.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnDatabaseSetup);
            this.panel1.Controls.Add(this.btnDataEntry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 673);
            this.panel1.TabIndex = 1;
            // 
            // btnDatabaseSetup
            // 
            this.btnDatabaseSetup.Location = new System.Drawing.Point(80, 154);
            this.btnDatabaseSetup.Name = "btnDatabaseSetup";
            this.btnDatabaseSetup.Size = new System.Drawing.Size(140, 84);
            this.btnDatabaseSetup.TabIndex = 0;
            this.btnDatabaseSetup.Text = "انشاء قاعدة بيانات";
            this.btnDatabaseSetup.UseVisualStyleBackColor = true;
            this.btnDatabaseSetup.Click += new System.EventHandler(this.btnDatabaseSetup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 673);
            this.panel2.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(80, 244);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(140, 84);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "التقارير";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حاسبة المصروفات";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDatabaseSetup;
        private System.Windows.Forms.Button btnReports;
    }
}

