namespace Expense_Calculator.Forms
{
    partial class BackupForm
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
            this.btnBackupNow = new System.Windows.Forms.Button();
            this.btnConfigureBackup = new System.Windows.Forms.Button();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackupNow
            // 
            this.btnBackupNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackupNow.Image = global::Expense_Calculator.Properties.Resources.Data_Backup;
            this.btnBackupNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupNow.Location = new System.Drawing.Point(442, 49);
            this.btnBackupNow.Name = "btnBackupNow";
            this.btnBackupNow.Size = new System.Drawing.Size(313, 142);
            this.btnBackupNow.TabIndex = 3;
            this.btnBackupNow.Text = "اخذ نسخة احتياطية";
            this.btnBackupNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackupNow.UseVisualStyleBackColor = true;
            this.btnBackupNow.Click += new System.EventHandler(this.btnBackupNow_Click);
            // 
            // btnConfigureBackup
            // 
            this.btnConfigureBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfigureBackup.Image = global::Expense_Calculator.Properties.Resources.Database_Administrator;
            this.btnConfigureBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigureBackup.Location = new System.Drawing.Point(442, 242);
            this.btnConfigureBackup.Name = "btnConfigureBackup";
            this.btnConfigureBackup.Size = new System.Drawing.Size(313, 142);
            this.btnConfigureBackup.TabIndex = 4;
            this.btnConfigureBackup.Text = "اعدادات النسخ الاحتياطي";
            this.btnConfigureBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfigureBackup.UseVisualStyleBackColor = true;
            this.btnConfigureBackup.Click += new System.EventHandler(this.btnConfigureBackup_Click);
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestoreBackup.Image = global::Expense_Calculator.Properties.Resources.Restore_win_11;
            this.btnRestoreBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreBackup.Location = new System.Drawing.Point(108, 49);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Size = new System.Drawing.Size(313, 142);
            this.btnRestoreBackup.TabIndex = 4;
            this.btnRestoreBackup.Text = "استعادة النسخة الاحتياطية";
            this.btnRestoreBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestoreBackup.UseVisualStyleBackColor = true;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 401);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(862, 72);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(862, 473);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRestoreBackup);
            this.Controls.Add(this.btnConfigureBackup);
            this.Controls.Add(this.btnBackupNow);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النسخ الاحتياطي واستعادة البيانات";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackupNow;
        private System.Windows.Forms.Button btnConfigureBackup;
        private System.Windows.Forms.Button btnRestoreBackup;
        private System.Windows.Forms.Label lblStatus;
    }
}