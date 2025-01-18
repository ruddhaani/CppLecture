using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Plantify.Dtos.CartDtos;

namespace Plantify.Entity
{
    public class Cart
    {
        public Cart()
        {

        }

        public Cart(AddToCartDto addToCartDto)
        {
            ProductId = addToCartDto.ProductId;
            UserId = addToCartDto.UserId;
            Quantity = addToCartDto.Quantity;
        }

        public Cart(UpdateQuantityDto updateQuantityDto)
        {
            ProductId = updateQuantityDto.ProductId;
            Quantity = updateQuantityDto.Quantity;
        }

        [Key]
        public int CartId { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserInformation UserInformation { get; set; }

        public int Quantity { get; set; }
    }
}
