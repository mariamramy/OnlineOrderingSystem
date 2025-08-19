using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineOrderingSystem.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryID { get; set; }

        [Required]
        [StringLength(50)]
        public string DeliveryMan { get; set; }

        [StringLength(20)]
        public string DeliveryStatus { get; set; }

        public TimeSpan? DeliveryTime { get; set; }

        // Foreign Key
        public int? Order_ID { get; set; }

        // Navigation properties
        [ForeignKey("Order_ID")]
        public virtual Order Order { get; set; }
    }
}