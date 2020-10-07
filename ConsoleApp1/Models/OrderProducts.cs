using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models
{
    public class OrderProducts
    {
        public int Id { get; set; }
        public int OrderId { get; set; } 
        public int Productid { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}