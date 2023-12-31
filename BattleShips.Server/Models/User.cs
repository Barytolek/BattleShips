﻿using System.ComponentModel.DataAnnotations;

namespace BattleShips.Server.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
