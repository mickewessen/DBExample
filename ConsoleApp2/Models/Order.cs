using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProducts>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Order")]
        public virtual Customer Customer { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}
