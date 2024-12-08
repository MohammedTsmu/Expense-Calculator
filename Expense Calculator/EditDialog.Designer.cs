namespace Expense_Calculator
{
    partial class EditDialog
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
            this.txtPurchases = new System.Windows.Forms.TextBox();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPurchases
            // 
            this.txtPurchases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchases.Location = new System.Drawing.Point(151, 322);
            this.txtPurchases.Name = "txtPurchases";
            this.txtPurchases.Size = new System.Drawing.Size(373, 33);
            this.txtPurchases.TabIndex = 12;
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRestaurant.Location = new System.Drawing.Point(151, 270);
            this.txtRestaurant.Name = "txtRestaurant";
            this.txtRestaurant.Size = new System.Drawing.Size(373, 33);
            this.txtRestaurant.TabIndex = 11;
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaintenance.Location = new System.Drawing.Point(151, 218);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(373, 33);
            this.txtMaintenance.TabIndex = 10;
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpExpenseDate.Location = new System.Drawing.Point(151, 166);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(373, 33);
            this.dtpExpenseDate.TabIndex = 9;
            // 
            // lblPurchases
            // 
            this.lblPurchases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPurchases.Image = global::Expense_Calculator.Properties.Resources.Add_Shopping_Cart;
            this.lblPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPurchases.Location = new System.Drawing.Point(499, 308);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(252, 47);
            this.lblPurchases.TabIndex = 5;
            this.lblPurchases.Text = "مصاريف المشتريات:";
            this.lblPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRestaurant.Image = global::Expense_Calculator.Properties.Resources.Restaurant;
            this.lblRestaurant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRestaurant.Location = new System.Drawing.Point(499, 256);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(252, 47);
            this.lblRestaurant.TabIndex = 6;
            this.lblRestaurant.Text = "مصاريف المطعم:";
            this.lblRestaurant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaintenance.Image = global::Expense_Calculator.Properties.Resources.Service;
            this.lblMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaintenance.Location = new System.Drawing.Point(499, 204);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(252, 47);
            this.lblMaintenance.TabIndex = 7;
            this.lblMaintenance.Text = "مصاريف الصيانة:";
            this.lblMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.Image = global::Expense_Calculator.Properties.Resources.Time_Machine;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(499, 152);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(252, 47);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "التاريخ:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Image = global::Expense_Calculator.Properties.Resources.Save_Close;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(364, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 79);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 583);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPurchases);
            this.Controls.Add(this.txtRestaurant);
            this.Controls.Add(this.txtMaintenance);
            this.Controls.Add(this.dtpExpenseDate);
            this.Controls.Add(this.lblPurchases);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.lblMaintenance);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل السجل";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPurchases;
        private System.Windows.Forms.TextBox txtRestaurant;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
    }
}