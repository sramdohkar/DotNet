using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkZone.Models
{
    public class InnerComments
    {
        [Key]
        public string InnerCommentID { get; set; }
        public string CommentID { get; set; }
        public string InnerComment { get; set; }
        public DateTime PostedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string UserID { get; set; }

        public Comments Comments { get; set; }
        public ApplicationUser User { get; set; }
    }
}