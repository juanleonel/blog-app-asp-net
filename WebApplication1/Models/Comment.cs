using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Body { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public Post Post { get; set; }
        public string UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
