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
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.txtPurchases = new System.Windows.Forms.TextBox();
            this.pnMainForm = new System.Windows.Forms.Panel();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.Image = global::Expense_Calculator.Properties.Resources.Restaurant;
            this.lblRestaurant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRestaurant.Location = new System.Drawing.Point(578, 163);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(223, 47);
            this.lblRestaurant.TabIndex = 0;
            this.lblRestaurant.Text = "مصاريف المطاعم:";
            this.lblRestaurant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPurchases
            // 
            this.lblPurchases.Image = global::Expense_Calculator.Properties.Resources.Add_Shopping_Cart;
            this.lblPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPurchases.Location = new System.Drawing.Point(564, 215);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(237, 47);
            this.lblPurchases.TabIndex = 0;
            this.lblPurchases.Text = "مصاريف المشتريات:";
            this.lblPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(173, 73);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(373, 33);
            this.dtpDate.TabIndex = 1;
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Location = new System.Drawing.Point(173, 125);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(373, 33);
            this.txtMaintenance.TabIndex = 2;
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.Location = new System.Drawing.Point(173, 177);
            this.txtRestaurant.Name = "txtRestaurant";
            this.txtRestaurant.Size = new System.Drawing.Size(373, 33);
            this.txtRestaurant.TabIndex = 3;
            // 
            // txtPurchases
            // 
            this.txtPurchases.Location = new System.Drawing.Point(173, 229);
            this.txtPurchases.Name = "txtPurchases";
            this.txtPurchases.Size = new System.Drawing.Size(373, 33);
            this.txtPurchases.TabIndex = 4;
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
            // btnClear
            // 
            this.btnClear.Image = global::Expense_Calculator.Properties.Resources.Cancel;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(173, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 79);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "مسح الحقول";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Expense_Calculator.Properties.Resources.Save_Close;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(371, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 79);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.Image = global::Expense_Calculator.Properties.Resources.Service;
            this.lblMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaintenance.Location = new System.Drawing.Point(591, 111);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(210, 47);
            this.lblMaintenance.TabIndex = 0;
            this.lblMaintenance.Text = "مصاريف الصيانة:";
            this.lblMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Image = global::Expense_Calculator.Properties.Resources.Time_Machine;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(672, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 47);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "التاريخ:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 647);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(929, 26);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "label1";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnMainForm);
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
        private System.Windows.Forms.Panel pnMainForm;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Label lblStatus;
    }
}