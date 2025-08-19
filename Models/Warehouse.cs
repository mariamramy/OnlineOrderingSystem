using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineOrderingSystem.Models
{
    public class Warehouse
    {
        [Key]
        public int Warehouse_num { get; set; }

        [StringLength(50)]
        public string Warehouse_City { get; set; }

        // Foreign Key
        public int? RestaurantID { get; set; }

        // Navigation properties
        [ForeignKey("RestaurantID")]
        public virtual Restaurant Restaurant { get; set; }


    }
}