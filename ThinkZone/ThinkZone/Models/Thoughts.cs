using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkZone.Models
{
    public class Thoughts
    {
        //Sample Change
        [Key]
        public string ThoughtID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string PathID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public string LevelID { get; set; }

        public Path Path { get; set; }
        public Level Level { get; set; }
        public ApplicationUser User { get; set; }
    }
}