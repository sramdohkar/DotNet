using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkZone.Models
{
    public class Review
    {
        [Key]
        public string ReviewID { get; set; }
        public string UserID { get; set; }
        public string ReviewerComment { get; set; }
        public string LevelID { get; set; }
        public string ThoughtID { get; set; }

        public Level Level { get; set; }
        public Thoughts Thoughts { get; set; }
        public ApplicationUser User { get; set; }
    }
}