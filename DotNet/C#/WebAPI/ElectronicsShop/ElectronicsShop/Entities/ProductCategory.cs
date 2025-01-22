using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop.Entities
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }

        public string Category { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
