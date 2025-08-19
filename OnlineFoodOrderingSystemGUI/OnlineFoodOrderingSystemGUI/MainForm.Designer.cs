namespace OnlineFoodOrderingSystemGUI
{
    partial class MainForm
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnOrderItem = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnRestaurant = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(21, 26);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(109, 54);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(179, 26);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(106, 54);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(330, 26);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(102, 54);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnOrderItem
            // 
            this.btnOrderItem.Location = new System.Drawing.Point(490, 26);
            this.btnOrderItem.Name = "btnOrderItem";
            this.btnOrderItem.Size = new System.Drawing.Size(103, 54);
            this.btnOrderItem.TabIndex = 3;
            this.btnOrderItem.Text = "OrderItem";
            this.btnOrderItem.UseVisualStyleBackColor = true;
            this.btnOrderItem.Click += new System.EventHandler(this.btnOrderItem_Click);
            // 
            // btnMeal
            // 
            this.btnMeal.Location = new System.Drawing.Point(657, 26);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(107, 54);
            this.btnMeal.TabIndex = 4;
            this.btnMeal.Text = "Meal";
            this.btnMeal.UseVisualStyleBackColor = true;
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.Location = new System.Drawing.Point(21, 124);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Size = new System.Drawing.Size(109, 60);
            this.btnRestaurant.TabIndex = 5;
            this.btnRestaurant.Text = "Restaurant";
            this.btnRestaurant.UseVisualStyleBackColor = true;
            this.btnRestaurant.Click += new System.EventHandler(this.btnRestaurant_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(179, 127);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(106, 57);
            this.btnDelivery.TabIndex = 6;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(330, 127);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(102, 57);
            this.btnWarehouse.TabIndex = 7;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnCoupon
            // 
            this.btnCoupon.Location = new System.Drawing.Point(490, 124);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(103, 60);
            this.btnCoupon.TabIndex = 8;
            this.btnCoupon.Text = "Coupon";
            this.btnCoupon.UseVisualStyleBackColor = true;
            this.btnCoupon.Click += new System.EventHandler(this.btnCoupon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCoupon);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.btnRestaurant);
            this.Controls.Add(this.btnMeal);
            this.Controls.Add(this.btnOrderItem);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnCustomer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnOrderItem;
        private System.Windows.Forms.Button btnMeal;
        private System.Windows.Forms.Button btnRestaurant;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnCoupon;
    }
}

