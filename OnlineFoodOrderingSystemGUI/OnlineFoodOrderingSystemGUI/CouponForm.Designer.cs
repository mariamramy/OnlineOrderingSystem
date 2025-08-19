namespace OnlineFoodOrderingSystemGUI
{
    partial class CouponForm
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
            this.labOrderID = new System.Windows.Forms.Label();
            this.labDiscount = new System.Windows.Forms.Label();
            this.labExpiryDate = new System.Windows.Forms.Label();
            this.labCouponID = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtCouponID = new System.Windows.Forms.TextBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewCoupon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).BeginInit();
            this.SuspendLayout();
            // 
            // labOrderID
            // 
            this.labOrderID.AutoSize = true;
            this.labOrderID.Location = new System.Drawing.Point(421, 106);
            this.labOrderID.Name = "labOrderID";
            this.labOrderID.Size = new System.Drawing.Size(57, 16);
            this.labOrderID.TabIndex = 0;
            this.labOrderID.Text = "Order ID";
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.Location = new System.Drawing.Point(421, 34);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(59, 16);
            this.labDiscount.TabIndex = 1;
            this.labDiscount.Text = "Discount";
            // 
            // labExpiryDate
            // 
            this.labExpiryDate.AutoSize = true;
            this.labExpiryDate.Location = new System.Drawing.Point(38, 106);
            this.labExpiryDate.Name = "labExpiryDate";
            this.labExpiryDate.Size = new System.Drawing.Size(76, 16);
            this.labExpiryDate.TabIndex = 2;
            this.labExpiryDate.Text = "Expiry Date";
            // 
            // labCouponID
            // 
            this.labCouponID.AutoSize = true;
            this.labCouponID.Location = new System.Drawing.Point(38, 34);
            this.labCouponID.Name = "labCouponID";
            this.labCouponID.Size = new System.Drawing.Size(70, 16);
            this.labCouponID.TabIndex = 3;
            this.labCouponID.Text = "Coupon ID";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(499, 28);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(122, 22);
            this.txtDiscount.TabIndex = 4;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(499, 100);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(122, 22);
            this.txtOrderID.TabIndex = 5;
            // 
            // txtCouponID
            // 
            this.txtCouponID.Location = new System.Drawing.Point(138, 28);
            this.txtCouponID.Name = "txtCouponID";
            this.txtCouponID.Size = new System.Drawing.Size(114, 22);
            this.txtCouponID.TabIndex = 6;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(138, 106);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(229, 22);
            this.dtpExpiryDate.TabIndex = 7;
            this.dtpExpiryDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(155, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCoupon
            // 
            this.dataGridViewCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoupon.Location = new System.Drawing.Point(12, 261);
            this.dataGridViewCoupon.Name = "dataGridViewCoupon";
            this.dataGridViewCoupon.RowHeadersWidth = 51;
            this.dataGridViewCoupon.RowTemplate.Height = 24;
            this.dataGridViewCoupon.Size = new System.Drawing.Size(776, 177);
            this.dataGridViewCoupon.TabIndex = 12;
            // 
            // CouponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCoupon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.txtCouponID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.labCouponID);
            this.Controls.Add(this.labExpiryDate);
            this.Controls.Add(this.labDiscount);
            this.Controls.Add(this.labOrderID);
            this.Name = "CouponForm";
            this.Text = "CouponForm";
            this.Load += new System.EventHandler(this.CouponForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOrderID;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Label labExpiryDate;
        private System.Windows.Forms.Label labCouponID;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCouponID;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewCoupon;
    }
}