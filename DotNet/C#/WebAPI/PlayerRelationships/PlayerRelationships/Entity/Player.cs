using System.ComponentModel.DataAnnotations;

namespace PlayerRelationships.Entity
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public Backpack Backpack { get; set; }

        public List<Weapons> Weapons { get; set; }

        public List<Clans> Clans { get; set; }
    }
}
