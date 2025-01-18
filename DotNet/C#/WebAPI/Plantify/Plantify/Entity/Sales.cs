using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Plantify.Entity
{
    public class Sales
    {

        public Sales()
        {

        }

        public Sales(Cart cart)
        {
            ProductId = cart.ProductId;
            Product = cart.Product;
            UserId = cart.UserId;
            UserInformation = cart.UserInformation;
            Quantity = cart.Quantity;
        }

        [Key]
        public int SalesId { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserInformation UserInformation { get; set; }

        public int Quantity { get; set; }
    }
}
