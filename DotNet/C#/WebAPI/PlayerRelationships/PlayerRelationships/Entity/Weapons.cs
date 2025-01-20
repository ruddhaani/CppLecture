using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PlayerRelationships.Entity
{
    public class Weapons
    {
        [Key]
        public int WeaponId { get; set; }

        public string WeaponName { get; set; }

        public int PlayerId { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }
    }
}
