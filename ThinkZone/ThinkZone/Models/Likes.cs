using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkZone.Models
{
    public class Likes
    {
        [Key]
        public string LikeID { get; set; }
        public string ThoughtID { get; set; }
        public string UserID { get; set; }
        public bool IsLike { get; set; }

        public Thoughts Thoughts { get; set; }
        public ApplicationUser User { get; set; }
    }
}