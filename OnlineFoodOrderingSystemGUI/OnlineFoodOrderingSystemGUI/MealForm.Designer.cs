namespace OnlineFoodOrderingSystemGUI
{
    partial class MealForm
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
            this.labMealID = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labCategory = new System.Windows.Forms.Label();
            this.labMealName = new System.Windows.Forms.Label();
            this.labRestaurantID = new System.Windows.Forms.Label();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMealID = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtRestaurantID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewMeal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // labMealID
            // 
            this.labMealID.AutoSize = true;
            this.labMealID.Location = new System.Drawing.Point(33, 37);
            this.labMealID.Name = "labMealID";
            this.labMealID.Size = new System.Drawing.Size(53, 16);
            this.labMealID.TabIndex = 0;
            this.labMealID.Text = "Meal ID";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(33, 79);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(38, 16);
            this.labPrice.TabIndex = 1;
            this.labPrice.Text = "Price";
            // 
            // labCategory
            // 
            this.labCategory.AutoSize = true;
            this.labCategory.Location = new System.Drawing.Point(388, 79);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(62, 16);
            this.labCategory.TabIndex = 2;
            this.labCategory.Text = "Category";
            // 
            // labMealName
            // 
            this.labMealName.AutoSize = true;
            this.labMealName.Location = new System.Drawing.Point(388, 37);
            this.labMealName.Name = "labMealName";
            this.labMealName.Size = new System.Drawing.Size(77, 16);
            this.labMealName.TabIndex = 3;
            this.labMealName.Text = "Meal Name";
            // 
            // labRestaurantID
            // 
            this.labRestaurantID.AutoSize = true;
            this.labRestaurantID.Location = new System.Drawing.Point(33, 118);
            this.labRestaurantID.Name = "labRestaurantID";
            this.labRestaurantID.Size = new System.Drawing.Size(88, 16);
            this.labRestaurantID.TabIndex = 4;
            this.labRestaurantID.Text = "Restaurant ID";
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(497, 31);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(154, 22);
            this.txtMealName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(142, 73);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(133, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // txtMealID
            // 
            this.txtMealID.Location = new System.Drawing.Point(142, 31);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(133, 22);
            this.txtMealID.TabIndex = 7;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Pizza",
            "Burger",
            "Dessert",
            "Drink"});
            this.cmbCategory.Location = new System.Drawing.Point(497, 79);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(154, 24);
            this.cmbCategory.TabIndex = 8;
            // 
            // txtRestaurantID
            // 
            this.txtRestaurantID.Location = new System.Drawing.Point(142, 118);
            this.txtRestaurantID.Name = "txtRestaurantID";
            this.txtRestaurantID.Size = new System.Drawing.Size(133, 22);
            this.txtRestaurantID.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(133, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(350, 212);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(236, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMeal
            // 
            this.dataGridViewMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeal.Location = new System.Drawing.Point(12, 275);
            this.dataGridViewMeal.Name = "dataGridViewMeal";
            this.dataGridViewMeal.RowHeadersWidth = 51;
            this.dataGridViewMeal.RowTemplate.Height = 24;
            this.dataGridViewMeal.Size = new System.Drawing.Size(776, 163);
            this.dataGridViewMeal.TabIndex = 14;
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMeal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRestaurantID);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtMealID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.labRestaurantID);
            this.Controls.Add(this.labMealName);
            this.Controls.Add(this.labCategory);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labMealID);
            this.Name = "MealForm";
            this.Text = "MealForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMealID;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.Label labMealName;
        private System.Windows.Forms.Label labRestaurantID;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMealID;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtRestaurantID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewMeal;
    }
}