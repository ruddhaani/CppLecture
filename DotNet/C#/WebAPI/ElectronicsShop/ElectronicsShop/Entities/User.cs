using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public long Phone { get; set; }

        public string Password { get; set; }

        public Cart Cart { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
