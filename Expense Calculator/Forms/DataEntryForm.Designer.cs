namespace Expense_Calculator
{
    partial class DataEntryForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.txtPurchases = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.TextBox();
            this.pnMainForm = new System.Windows.Forms.Panel();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.pnMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(590, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 26);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "التاريخ:";
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Location = new System.Drawing.Point(509, 93);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(148, 26);
            this.lblMaintenance.TabIndex = 0;
            this.lblMaintenance.Text = "مصاريف الصيانة:";
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Location = new System.Drawing.Point(496, 132);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(161, 26);
            this.lblRestaurant.TabIndex = 0;
            this.lblRestaurant.Text = "مصاريف المطاعم:";
            // 
            // lblPurchases
            // 
            this.lblPurchases.AutoSize = true;
            this.lblPurchases.Location = new System.Drawing.Point(482, 174);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(175, 26);
            this.lblPurchases.TabIndex = 0;
            this.lblPurchases.Text = "مصاريف المشتريات:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(98, 47);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(373, 33);
            this.dtpDate.TabIndex = 1;
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Location = new System.Drawing.Point(98, 91);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(373, 33);
            this.txtMaintenance.TabIndex = 2;
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.Location = new System.Drawing.Point(98, 130);
            this.txtRestaurant.Name = "txtRestaurant";
            this.txtRestaurant.Size = new System.Drawing.Size(373, 33);
            this.txtRestaurant.TabIndex = 3;
            // 
            // txtPurchases
            // 
            this.txtPurchases.Location = new System.Drawing.Point(98, 169);
            this.txtPurchases.Name = "txtPurchases";
            this.txtPurchases.Size = new System.Drawing.Size(373, 33);
            this.txtPurchases.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 79);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 79);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "مسح الحقول";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 434);
            this.lblStatus.Multiline = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(649, 182);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnMainForm
            // 
            this.pnMainForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnMainForm.Controls.Add(this.btnMainForm);
            this.pnMainForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMainForm.Location = new System.Drawing.Point(929, 0);
            this.pnMainForm.Name = "pnMainForm";
            this.pnMainForm.Size = new System.Drawing.Size(133, 673);
            this.pnMainForm.TabIndex = 8;
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMainForm.Location = new System.Drawing.Point(7, 12);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(126, 124);
            this.btnMainForm.TabIndex = 0;
            this.btnMainForm.Text = "الصفحة الرئيسية";
            this.btnMainForm.UseVisualStyleBackColor = false;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click_1);
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pnMainForm);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPurchases);
            this.Controls.Add(this.txtRestaurant);
            this.Controls.Add(this.txtMaintenance);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblPurchases);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.lblMaintenance);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataEntryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدخال البيانات";
            this.pnMainForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.TextBox txtRestaurant;
        private System.Windows.Forms.TextBox txtPurchases;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox lblStatus;
        private System.Windows.Forms.Panel pnMainForm;
        private System.Windows.Forms.Button btnMainForm;
    }
}