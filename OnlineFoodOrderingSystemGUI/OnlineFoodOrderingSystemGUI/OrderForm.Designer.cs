namespace OnlineFoodOrderingSystemGUI
{
    partial class OrderForm
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
            this.labPaymentID = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.Label();
            this.labCustomerID = new System.Windows.Forms.Label();
            this.labRestaurantID = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.txtRestaurantID = new System.Windows.Forms.TextBox();
            this.dtpOrderDate1 = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // labOrderID
            // 
            this.labOrderID.AutoSize = true;
            this.labOrderID.Location = new System.Drawing.Point(32, 34);
            this.labOrderID.Name = "labOrderID";
            this.labOrderID.Size = new System.Drawing.Size(57, 16);
            this.labOrderID.TabIndex = 0;
            this.labOrderID.Text = "Order ID";
            // 
            // labPaymentID
            // 
            this.labPaymentID.AutoSize = true;
            this.labPaymentID.Location = new System.Drawing.Point(32, 82);
            this.labPaymentID.Name = "labPaymentID";
            this.labPaymentID.Size = new System.Drawing.Size(76, 16);
            this.labPaymentID.TabIndex = 1;
            this.labPaymentID.Text = "Payment ID";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.AutoSize = true;
            this.dtpOrderDate.Location = new System.Drawing.Point(32, 135);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(73, 16);
            this.dtpOrderDate.TabIndex = 2;
            this.dtpOrderDate.Text = "Order Date";
            // 
            // labCustomerID
            // 
            this.labCustomerID.AutoSize = true;
            this.labCustomerID.Location = new System.Drawing.Point(398, 34);
            this.labCustomerID.Name = "labCustomerID";
            this.labCustomerID.Size = new System.Drawing.Size(80, 16);
            this.labCustomerID.TabIndex = 3;
            this.labCustomerID.Text = "Customer ID";
            // 
            // labRestaurantID
            // 
            this.labRestaurantID.AutoSize = true;
            this.labRestaurantID.Location = new System.Drawing.Point(398, 82);
            this.labRestaurantID.Name = "labRestaurantID";
            this.labRestaurantID.Size = new System.Drawing.Size(88, 16);
            this.labRestaurantID.TabIndex = 4;
            this.labRestaurantID.Text = "Restaurant ID";
            this.labRestaurantID.Click += new System.EventHandler(this.labRestaurantID_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(398, 135);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(44, 16);
            this.labStatus.TabIndex = 5;
            this.labStatus.Text = "Status";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(133, 28);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(134, 22);
            this.txtOrderID.TabIndex = 6;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(520, 28);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(137, 22);
            this.txtCustomerID.TabIndex = 7;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(133, 76);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(134, 22);
            this.txtPaymentID.TabIndex = 8;
            // 
            // txtRestaurantID
            // 
            this.txtRestaurantID.Location = new System.Drawing.Point(520, 76);
            this.txtRestaurantID.Name = "txtRestaurantID";
            this.txtRestaurantID.Size = new System.Drawing.Size(137, 22);
            this.txtRestaurantID.TabIndex = 9;
            // 
            // dtpOrderDate1
            // 
            this.dtpOrderDate1.Location = new System.Drawing.Point(133, 129);
            this.dtpOrderDate1.Name = "dtpOrderDate1";
            this.dtpOrderDate1.Size = new System.Drawing.Size(233, 22);
            this.dtpOrderDate1.TabIndex = 10;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pinding",
            "Confirmed",
            "Delivered",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(520, 127);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(137, 24);
            this.cmbStatus.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(261, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(375, 223);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 288);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewOrders.TabIndex = 16;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpOrderDate1);
            this.Controls.Add(this.txtRestaurantID);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labRestaurantID);
            this.Controls.Add(this.labCustomerID);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.labPaymentID);
            this.Controls.Add(this.labOrderID);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOrderID;
        private System.Windows.Forms.Label labPaymentID;
        private System.Windows.Forms.Label dtpOrderDate;
        private System.Windows.Forms.Label labCustomerID;
        private System.Windows.Forms.Label labRestaurantID;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.TextBox txtRestaurantID;
        private System.Windows.Forms.DateTimePicker dtpOrderDate1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
    }
}