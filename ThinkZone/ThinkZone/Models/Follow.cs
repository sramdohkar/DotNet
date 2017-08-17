using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkZone.Models
{
    public class Follow
    {
        [Key]
        public string FollowID { get; set; }
        public string ThoughtID { get; set; }
        public string UserID { get; set; }
        public bool IsFollow { get; set; }

        public Thoughts Thoughts { get; set; }
        public ApplicationUser User { get; set; }
    }
}