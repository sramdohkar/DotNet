using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkZone.Models
{
    public class Level
    {
        [Key]
        public string LevelID { get; set; }
        public string LevelName { get; set; }
        public string PathID { get; set; }
        public string UserID { get; set; }
        public DateTime EnteredAt { get; set; }
        public DateTime MovedAt { get; set; }
        public bool IsBlocked { get; set; }

        public Path Path { get; set; }
        public ApplicationUser User { get; set; }
    }
}