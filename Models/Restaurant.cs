using OnlineOrderingSystem.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineOrderingSystem.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }

        [Required]
        [StringLength(100)]
        public string RestaurantName { get; set; }

        [StringLength(15)]
        public string Restaurant_phone { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        // Navigation properties
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }

        public Restaurant()
        {
            Orders = new HashSet<Order>();
            Meals = new HashSet<Meal>();
            Warehouses = new HashSet<Warehouse>();
        }
    }
}