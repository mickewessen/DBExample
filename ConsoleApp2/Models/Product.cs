using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProducts>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}
