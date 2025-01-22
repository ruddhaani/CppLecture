using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public double ProductPrice { get; set; }

        public long ProductStockQuantity { get; set; }

        public int ProductCategoryId { get; set; }
        
        public ProductCategory ProductCategory { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
