namespace Expense_Calculator
{
    partial class DatabaseSetupForm
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
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnSaveAndInitialize = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMainForm = new System.Windows.Forms.Panel();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnMainForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(550, 225);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerName.Size = new System.Drawing.Size(105, 26);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "اسم الخادم";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(486, 298);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDatabaseName.Size = new System.Drawing.Size(169, 26);
            this.lblDatabaseName.TabIndex = 0;
            this.lblDatabaseName.Text = "اسم قاعدة البيانات";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(281, 14);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(171, 72);
            this.btnTestConnection.TabIndex = 1;
            this.btnTestConnection.Text = "اختبار الاتصال";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnSaveAndInitialize
            // 
            this.btnSaveAndInitialize.Location = new System.Drawing.Point(611, 14);
            this.btnSaveAndInitialize.Name = "btnSaveAndInitialize";
            this.btnSaveAndInitialize.Size = new System.Drawing.Size(171, 72);
            this.btnSaveAndInitialize.TabIndex = 1;
            this.btnSaveAndInitialize.Text = "حفظ وإنشاء قاعدة البيانات";
            this.btnSaveAndInitialize.UseVisualStyleBackColor = true;
            this.btnSaveAndInitialize.Click += new System.EventHandler(this.btnSaveAndInitialize_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(183, 225);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(269, 33);
            this.txtServerName.TabIndex = 2;
            this.txtServerName.Text = ".\\SQLEXPRESS";
            this.txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(183, 298);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDatabaseName.Size = new System.Drawing.Size(269, 33);
            this.txtDatabaseName.TabIndex = 2;
            this.txtDatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(0, 583);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1062, 90);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "اسم قاعدة البيانات";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pnMainForm);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDatabaseName);
            this.panel1.Controls.Add(this.txtDatabaseName);
            this.panel1.Controls.Add(this.lblServerName);
            this.panel1.Controls.Add(this.txtServerName);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 673);
            this.panel1.TabIndex = 3;
            // 
            // pnMainForm
            // 
            this.pnMainForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnMainForm.Controls.Add(this.btnMainForm);
            this.pnMainForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMainForm.Location = new System.Drawing.Point(929, 0);
            this.pnMainForm.Name = "pnMainForm";
            this.pnMainForm.Size = new System.Drawing.Size(133, 483);
            this.pnMainForm.TabIndex = 9;
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMainForm.Location = new System.Drawing.Point(4, 12);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(126, 124);
            this.btnMainForm.TabIndex = 0;
            this.btnMainForm.Text = "الصفحة الرئيسية";
            this.btnMainForm.UseVisualStyleBackColor = false;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btnSaveAndInitialize);
            this.panel2.Controls.Add(this.btnTestConnection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 100);
            this.panel2.TabIndex = 3;
            // 
            // DatabaseSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DatabaseSetupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseSetupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnMainForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnSaveAndInitialize;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnMainForm;
        private System.Windows.Forms.Button btnMainForm;
    }
}