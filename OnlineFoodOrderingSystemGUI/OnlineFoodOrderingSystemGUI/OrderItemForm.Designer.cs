namespace OnlineFoodOrderingSystemGUI
{
    partial class OrderItemForm
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
            this.labOrderItemID = new System.Windows.Forms.Label();
            this.labMealID = new System.Windows.Forms.Label();
            this.labOrderID = new System.Windows.Forms.Label();
            this.labQuantity = new System.Windows.Forms.Label();
            this.txtOrderItemID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtMealID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewOrderItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labOrderItemID
            // 
            this.labOrderItemID.AutoSize = true;
            this.labOrderItemID.Location = new System.Drawing.Point(35, 44);
            this.labOrderItemID.Name = "labOrderItemID";
            this.labOrderItemID.Size = new System.Drawing.Size(85, 16);
            this.labOrderItemID.TabIndex = 0;
            this.labOrderItemID.Text = "Order Item ID";
            // 
            // labMealID
            // 
            this.labMealID.AutoSize = true;
            this.labMealID.Location = new System.Drawing.Point(35, 102);
            this.labMealID.Name = "labMealID";
            this.labMealID.Size = new System.Drawing.Size(53, 16);
            this.labMealID.TabIndex = 1;
            this.labMealID.Text = "Meal ID";
            // 
            // labOrderID
            // 
            this.labOrderID.AutoSize = true;
            this.labOrderID.Location = new System.Drawing.Point(411, 44);
            this.labOrderID.Name = "labOrderID";
            this.labOrderID.Size = new System.Drawing.Size(57, 16);
            this.labOrderID.TabIndex = 2;
            this.labOrderID.Text = "Order ID";
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.Location = new System.Drawing.Point(411, 102);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(55, 16);
            this.labQuantity.TabIndex = 3;
            this.labQuantity.Text = "Quantity";
            // 
            // txtOrderItemID
            // 
            this.txtOrderItemID.Location = new System.Drawing.Point(135, 38);
            this.txtOrderItemID.Name = "txtOrderItemID";
            this.txtOrderItemID.Size = new System.Drawing.Size(170, 22);
            this.txtOrderItemID.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(484, 99);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(140, 22);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(484, 38);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(140, 22);
            this.txtOrderID.TabIndex = 6;
            // 
            // txtMealID
            // 
            this.txtMealID.Location = new System.Drawing.Point(135, 96);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(170, 22);
            this.txtMealID.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(359, 205);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrderItem
            // 
            this.dataGridViewOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItem.Location = new System.Drawing.Point(12, 272);
            this.dataGridViewOrderItem.Name = "dataGridViewOrderItem";
            this.dataGridViewOrderItem.RowHeadersWidth = 51;
            this.dataGridViewOrderItem.RowTemplate.Height = 24;
            this.dataGridViewOrderItem.Size = new System.Drawing.Size(776, 166);
            this.dataGridViewOrderItem.TabIndex = 12;
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrderItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtMealID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOrderItemID);
            this.Controls.Add(this.labQuantity);
            this.Controls.Add(this.labOrderID);
            this.Controls.Add(this.labMealID);
            this.Controls.Add(this.labOrderItemID);
            this.Name = "OrderItemForm";
            this.Text = "OrderItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOrderItemID;
        private System.Windows.Forms.Label labMealID;
        private System.Windows.Forms.Label labOrderID;
        private System.Windows.Forms.Label labQuantity;
        private System.Windows.Forms.TextBox txtOrderItemID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtMealID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewOrderItem;
    }
}