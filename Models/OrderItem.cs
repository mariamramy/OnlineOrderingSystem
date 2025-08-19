using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineOrderingSystem.Models
{
    public class OrderItem
    {
        // Composite Key Properties
        public int Item_ID { get; set; }
        public int Order_ID { get; set; }
        public int Meal_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Item_name { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal? Item_weight { get; set; }

        // Navigation properties
        [ForeignKey("Order_ID")]
        public virtual Order Order { get; set; }

        [ForeignKey("Meal_ID")]
        public virtual Meal Meal { get; set; }
    }
}