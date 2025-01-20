using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductUserRelationship.Entity
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        [JsonIgnore]
        public List<Products> Products { get; set; }
    }
}
