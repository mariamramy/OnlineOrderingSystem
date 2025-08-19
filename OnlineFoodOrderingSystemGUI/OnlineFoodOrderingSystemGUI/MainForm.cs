using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFoodOrderingSystemGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cusForm = new CustomerForm();
            cusForm.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentForm payForm = new PaymentForm();
            payForm.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm ordForm = new OrderForm();
            ordForm.ShowDialog();
        }

        private void btnOrderItem_Click(object sender, EventArgs e)
        {
            OrderItemForm ordIteForm = new OrderItemForm();
            ordIteForm.ShowDialog();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            MealForm meaForm = new MealForm();
            meaForm.ShowDialog();
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantForm resForm = new RestaurantForm();
            resForm.ShowDialog();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            DeliveryForm delForm = new DeliveryForm();
            delForm.ShowDialog();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseForm warHouForm = new WarehouseForm();
            warHouForm.ShowDialog();
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            CouponForm couForm = new CouponForm();
            couForm.ShowDialog();
        }
    }
}
