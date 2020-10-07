using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Models
{
    public partial class OrderProducts
    {
        [Key]
        public int OrderId { get; set; }
        [Key]
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderProducts")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("OrderProducts")]
        public virtual Product Product { get; set; }
    }
}
