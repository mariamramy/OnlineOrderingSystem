using OnlineOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineOrderingSystem.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }

        [Required]
        public DateTime Order_Date { get; set; }

        [Required]
        [StringLength(20)]
        public string Order_status { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        // Foreign Keys
        public int? Customer_ID { get; set; }

        [StringLength(20)]
        public string Coupon_Code { get; set; }

        public int? RestaurantID { get; set; }

        // Navigation properties
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("Coupon_Code")]
        public virtual Coupon Coupon { get; set; }

        [ForeignKey("RestaurantID")]
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }

        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            Payments = new HashSet<Payment>();
            Deliveries = new HashSet<Delivery>();
        }
    }
}