using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Comment
    {
        public int CommentID { get; set; }

        public string UserID { get; set; }

        public int PostID { get; set; }

        public ApplicationUser User { get; set; }

        [DataType(DataType.Text)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        public Comment()
        {
        }
    }
}
