using System.ComponentModel.DataAnnotations;

namespace Plantify.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductType { get; set; }

        public string Price { get; set; }

        public string ProductImageUrl { get; set; }
    }
}
