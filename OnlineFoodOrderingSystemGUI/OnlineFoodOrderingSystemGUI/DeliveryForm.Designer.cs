namespace OnlineFoodOrderingSystemGUI
{
    partial class DeliveryForm
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
            this.labDriverPhone = new System.Windows.Forms.Label();
            this.labOrderID = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labDriverName = new System.Windows.Forms.Label();
            this.labDeliveryID = new System.Windows.Forms.Label();
            this.txtDriverPhone = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtDeliveryID = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewDelivery = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // labDriverPhone
            // 
            this.labDriverPhone.AutoSize = true;
            this.labDriverPhone.Location = new System.Drawing.Point(397, 90);
            this.labDriverPhone.Name = "labDriverPhone";
            this.labDriverPhone.Size = new System.Drawing.Size(85, 16);
            this.labDriverPhone.TabIndex = 0;
            this.labDriverPhone.Text = "Driver Phone";
            // 
            // labOrderID
            // 
            this.labOrderID.AutoSize = true;
            this.labOrderID.Location = new System.Drawing.Point(397, 34);
            this.labOrderID.Name = "labOrderID";
            this.labOrderID.Size = new System.Drawing.Size(57, 16);
            this.labOrderID.TabIndex = 1;
            this.labOrderID.Text = "Order ID";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(31, 145);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(44, 16);
            this.labStatus.TabIndex = 2;
            this.labStatus.Text = "Status";
            // 
            // labDriverName
            // 
            this.labDriverName.AutoSize = true;
            this.labDriverName.Location = new System.Drawing.Point(31, 90);
            this.labDriverName.Name = "labDriverName";
            this.labDriverName.Size = new System.Drawing.Size(83, 16);
            this.labDriverName.TabIndex = 3;
            this.labDriverName.Text = "Driver Name";
            // 
            // labDeliveryID
            // 
            this.labDeliveryID.AutoSize = true;
            this.labDeliveryID.Location = new System.Drawing.Point(31, 34);
            this.labDeliveryID.Name = "labDeliveryID";
            this.labDeliveryID.Size = new System.Drawing.Size(73, 16);
            this.labDeliveryID.TabIndex = 4;
            this.labDeliveryID.Text = "Delivery ID";
            // 
            // txtDriverPhone
            // 
            this.txtDriverPhone.Location = new System.Drawing.Point(502, 84);
            this.txtDriverPhone.Name = "txtDriverPhone";
            this.txtDriverPhone.Size = new System.Drawing.Size(163, 22);
            this.txtDriverPhone.TabIndex = 5;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(502, 28);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(119, 22);
            this.txtOrderID.TabIndex = 6;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(140, 84);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(138, 22);
            this.txtDriverName.TabIndex = 7;
            // 
            // txtDeliveryID
            // 
            this.txtDeliveryID.Location = new System.Drawing.Point(140, 28);
            this.txtDeliveryID.Name = "txtDeliveryID";
            this.txtDeliveryID.Size = new System.Drawing.Size(110, 22);
            this.txtDeliveryID.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Out for delivery",
            "Delivered"});
            this.cmbStatus.Location = new System.Drawing.Point(140, 142);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(366, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(147, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDelivery
            // 
            this.dataGridViewDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelivery.Location = new System.Drawing.Point(10, 276);
            this.dataGridViewDelivery.Name = "dataGridViewDelivery";
            this.dataGridViewDelivery.RowHeadersWidth = 51;
            this.dataGridViewDelivery.RowTemplate.Height = 24;
            this.dataGridViewDelivery.Size = new System.Drawing.Size(778, 162);
            this.dataGridViewDelivery.TabIndex = 14;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDelivery);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtDeliveryID);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtDriverPhone);
            this.Controls.Add(this.labDeliveryID);
            this.Controls.Add(this.labDriverName);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labOrderID);
            this.Controls.Add(this.labDriverPhone);
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDriverPhone;
        private System.Windows.Forms.Label labOrderID;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labDriverName;
        private System.Windows.Forms.Label labDeliveryID;
        private System.Windows.Forms.TextBox txtDriverPhone;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtDeliveryID;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewDelivery;
    }
}