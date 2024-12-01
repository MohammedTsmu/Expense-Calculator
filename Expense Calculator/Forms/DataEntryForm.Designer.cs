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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.txtPurchases = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Location = new System.Drawing.Point(146, 152);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(373, 33);
            this.dtpDate.TabIndex = 1;
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaintenance.Location = new System.Drawing.Point(146, 204);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(373, 33);
            this.txtMaintenance.TabIndex = 2;
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRestaurant.Location = new System.Drawing.Point(146, 256);
            this.txtRestaurant.Name = "txtRestaurant";
            this.txtRestaurant.Size = new System.Drawing.Size(373, 33);
            this.txtRestaurant.TabIndex = 3;
            // 
            // txtPurchases
            // 
            this.txtPurchases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchases.Location = new System.Drawing.Point(146, 308);
            this.txtPurchases.Name = "txtPurchases";
            this.txtPurchases.Size = new System.Drawing.Size(373, 33);
            this.txtPurchases.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(892, 72);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Image = global::Expense_Calculator.Properties.Resources.Cancel;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(135, 36);
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
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Image = global::Expense_Calculator.Properties.Resources.Save_Close;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(583, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 79);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPurchases
            // 
            this.lblPurchases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPurchases.Image = global::Expense_Calculator.Properties.Resources.Add_Shopping_Cart;
            this.lblPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPurchases.Location = new System.Drawing.Point(494, 294);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(252, 47);
            this.lblPurchases.TabIndex = 0;
            this.lblPurchases.Text = "مصاريف المشتريات:";
            this.lblPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRestaurant.Image = global::Expense_Calculator.Properties.Resources.Restaurant;
            this.lblRestaurant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRestaurant.Location = new System.Drawing.Point(494, 242);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(252, 47);
            this.lblRestaurant.TabIndex = 0;
            this.lblRestaurant.Text = "مصاريف المطاعم:";
            this.lblRestaurant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaintenance.Image = global::Expense_Calculator.Properties.Resources.Service;
            this.lblMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaintenance.Location = new System.Drawing.Point(494, 190);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(252, 47);
            this.lblMaintenance.TabIndex = 0;
            this.lblMaintenance.Text = "مصاريف الصيانة:";
            this.lblMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.Image = global::Expense_Calculator.Properties.Resources.Time_Machine;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(494, 138);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(252, 47);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "التاريخ:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 217);
            this.panel1.TabIndex = 10;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 645);
            this.Controls.Add(this.panel1);
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
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدخال البيانات";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
    }
}