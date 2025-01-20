using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductUserRelationship.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public double Phone { get; set; }

        public string Password { get; set; }

        [JsonIgnore]
        public Cart Cart { get; set; }
    }
}
