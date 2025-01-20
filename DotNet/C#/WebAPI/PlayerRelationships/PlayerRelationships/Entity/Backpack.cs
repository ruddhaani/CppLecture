using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PlayerRelationships.Entity
{
    public class Backpack
    {
        [Key]
        public int BackpackId { get; set; }
        public string Color { get; set; }

        public int PlayerId { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }
    }
}
