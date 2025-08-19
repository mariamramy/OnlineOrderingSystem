using OnlineOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineOrderingSystem.Models
{
    public class Coupon
    {
        [Key]
        [StringLength(20)]
        public string Coupon_Code { get; set; }

        [Required]
        public int Coupon_Max_Usage { get; set; }

        [Required]
        public DateTime Coupon_Exp { get; set; }

        [Range(0, 100)]
        public decimal? Discount_Percent { get; set; }

        // Navigation properties
        public virtual ICollection<Order> Orders { get; set; }

        public Coupon()
        {
            Orders = new HashSet<Order>();
        }
    }
}