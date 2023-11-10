using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BattleShips.Server.Models
{
    public class Lobby
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string[] names { get; set; }

        [Required]
        public int match_id { get; set; }

        [AllowNull]
        public string password { get; set; }
    }
}
