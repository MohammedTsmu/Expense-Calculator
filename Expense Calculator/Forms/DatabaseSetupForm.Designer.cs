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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveAndInitialize = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServerName.Location = new System.Drawing.Point(280, 232);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(269, 33);
            this.txtServerName.TabIndex = 2;
            this.txtServerName.Text = ".\\SQLEXPRESS";
            this.txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatabaseName.Location = new System.Drawing.Point(280, 305);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDatabaseName.Size = new System.Drawing.Size(269, 33);
            this.txtDatabaseName.TabIndex = 2;
            this.txtDatabaseName.Text = "DB_EC";
            this.txtDatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(0, 583);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1062, 90);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txtDatabaseName);
            this.panel1.Controls.Add(this.txtServerName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDatabaseName);
            this.panel1.Controls.Add(this.lblServerName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 673);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnSaveAndInitialize);
            this.panel2.Controls.Add(this.btnTestConnection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnSaveAndInitialize
            // 
            this.btnSaveAndInitialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAndInitialize.Image = global::Expense_Calculator.Properties.Resources.Save_Close;
            this.btnSaveAndInitialize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAndInitialize.Location = new System.Drawing.Point(556, 14);
            this.btnSaveAndInitialize.Name = "btnSaveAndInitialize";
            this.btnSaveAndInitialize.Size = new System.Drawing.Size(280, 72);
            this.btnSaveAndInitialize.TabIndex = 1;
            this.btnSaveAndInitialize.Text = "حفظ وإنشاء قاعدة البيانات";
            this.btnSaveAndInitialize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAndInitialize.UseVisualStyleBackColor = true;
            this.btnSaveAndInitialize.Click += new System.EventHandler(this.btnSaveAndInitialize_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestConnection.Image = global::Expense_Calculator.Properties.Resources.Data_Transfer;
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(226, 14);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(280, 72);
            this.btnTestConnection.TabIndex = 1;
            this.btnTestConnection.Text = "اختبار الاتصال";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatabaseName.Image = global::Expense_Calculator.Properties.Resources.Database;
            this.lblDatabaseName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDatabaseName.Location = new System.Drawing.Point(522, 288);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDatabaseName.Size = new System.Drawing.Size(260, 50);
            this.lblDatabaseName.TabIndex = 0;
            this.lblDatabaseName.Text = "اسم قاعدة البيانات";
            this.lblDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServerName
            // 
            this.lblServerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServerName.Image = global::Expense_Calculator.Properties.Resources.Connect;
            this.lblServerName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServerName.Location = new System.Drawing.Point(522, 215);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerName.Size = new System.Drawing.Size(260, 50);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "اسم الخادم";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatabaseSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DatabaseSetupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انشاء وربط قاعدة البيانات والجداول";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}