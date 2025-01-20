using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PlayerRelationships.Entity
{
    public class Clans
    {
        [Key]
        public int ClanId { get; set; }

        public string ClanName { get; set; }

        public int PlayerId { get; set; }

        [JsonIgnore]
        public List<Player> Players { get; set; }
    }
}
