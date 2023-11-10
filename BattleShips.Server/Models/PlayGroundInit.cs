using System.ComponentModel.DataAnnotations;

namespace BattleShips.Server.Models
{
    public class PlayGroundInit
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public int match_id { get; set; } 
            
        [Required]
        public string[] shipsCoordinates { get; set; }

    }
}
