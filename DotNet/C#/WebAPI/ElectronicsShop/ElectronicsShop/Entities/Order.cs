using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop.Entities
{
    public class Order
    {
        [Key]

        public int OrderId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
