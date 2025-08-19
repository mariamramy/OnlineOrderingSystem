using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineOrderingSystem.Models
{
    public class Payment
    {
        [Key]
        public int Payment_id { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }

        [StringLength(20)]
        public string Payment_Status { get; set; }

        [StringLength(20)]
        public string Payment_Method { get; set; }

        // Foreign Keys
        public int? Customer_ID { get; set; }
        public int? Order_ID { get; set; }

        // Navigation properties
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("Order_ID")]
        public virtual Order Order { get; set; }
    }
}