using OnlineOrderingSystem.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineOrderingSystem.Models
{
    public class Meal
    {
        [Key]
        public int Meal_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Meal_name { get; set; }

        public string Meal_Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Meal_price { get; set; }

        // Foreign Key
        public int? RestaurantID { get; set; }

        // Navigation properties
        [ForeignKey("RestaurantID")]
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Meal()
        {
            OrderItems = new HashSet<OrderItem>();
        }
    }
}