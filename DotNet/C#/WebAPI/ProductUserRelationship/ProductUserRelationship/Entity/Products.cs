using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductUserRelationship.Entity
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public List<Cart> Cart { get; set; }
    }
}
