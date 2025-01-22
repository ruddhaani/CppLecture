using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop.Entities
{
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }


        public string Url { get; set; }

        public int ProductId {get;set;}

        public Product Product { get; set; }
    }
}
