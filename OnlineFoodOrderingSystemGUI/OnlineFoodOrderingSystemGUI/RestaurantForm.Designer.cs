namespace OnlineFoodOrderingSystemGUI
{
    partial class RestaurantForm
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
            this.labPhone = new System.Windows.Forms.Label();
            this.labRestaurantName = new System.Windows.Forms.Label();
            this.labLocation = new System.Windows.Forms.Label();
            this.labRestaurantID = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtRestaurantName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtRestaurantID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewRestaurant = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(377, 93);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(46, 16);
            this.labPhone.TabIndex = 0;
            this.labPhone.Text = "Phone";
            // 
            // labRestaurantName
            // 
            this.labRestaurantName.AutoSize = true;
            this.labRestaurantName.Location = new System.Drawing.Point(377, 42);
            this.labRestaurantName.Name = "labRestaurantName";
            this.labRestaurantName.Size = new System.Drawing.Size(112, 16);
            this.labRestaurantName.TabIndex = 1;
            this.labRestaurantName.Text = "Restaurant Name";
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Location = new System.Drawing.Point(36, 93);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(58, 16);
            this.labLocation.TabIndex = 2;
            this.labLocation.Text = "Location";
            // 
            // labRestaurantID
            // 
            this.labRestaurantID.AutoSize = true;
            this.labRestaurantID.Location = new System.Drawing.Point(36, 42);
            this.labRestaurantID.Name = "labRestaurantID";
            this.labRestaurantID.Size = new System.Drawing.Size(88, 16);
            this.labRestaurantID.TabIndex = 3;
            this.labRestaurantID.Text = "Restaurant ID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(516, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // txtRestaurantName
            // 
            this.txtRestaurantName.Location = new System.Drawing.Point(516, 36);
            this.txtRestaurantName.Name = "txtRestaurantName";
            this.txtRestaurantName.Size = new System.Drawing.Size(158, 22);
            this.txtRestaurantName.TabIndex = 5;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(151, 90);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(174, 22);
            this.txtLocation.TabIndex = 6;
            // 
            // txtRestaurantID
            // 
            this.txtRestaurantID.Location = new System.Drawing.Point(151, 36);
            this.txtRestaurantID.Name = "txtRestaurantID";
            this.txtRestaurantID.Size = new System.Drawing.Size(108, 22);
            this.txtRestaurantID.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(150, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(265, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRestaurant
            // 
            this.dataGridViewRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurant.Location = new System.Drawing.Point(19, 261);
            this.dataGridViewRestaurant.Name = "dataGridViewRestaurant";
            this.dataGridViewRestaurant.RowHeadersWidth = 51;
            this.dataGridViewRestaurant.RowTemplate.Height = 24;
            this.dataGridViewRestaurant.Size = new System.Drawing.Size(769, 177);
            this.dataGridViewRestaurant.TabIndex = 12;
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRestaurant);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRestaurantID);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtRestaurantName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labRestaurantID);
            this.Controls.Add(this.labLocation);
            this.Controls.Add(this.labRestaurantName);
            this.Controls.Add(this.labPhone);
            this.Name = "RestaurantForm";
            this.Text = "RestaurantForm";
            this.Load += new System.EventHandler(this.RestaurantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labRestaurantName;
        private System.Windows.Forms.Label labLocation;
        private System.Windows.Forms.Label labRestaurantID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtRestaurantName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtRestaurantID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewRestaurant;
    }
}