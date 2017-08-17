using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkZone.Models
{
    public class Comments
    {
        [Key]
        public string CommentID { get; set; }
        public string Comment { get; set; }
        public string ThoughtID { get; set; }
        public DateTime PostedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string UserID { get; set; }

        public Thoughts Thoughts { get; set; }
        public ApplicationUser User { get; set; }
    }
}