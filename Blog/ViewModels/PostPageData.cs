using System;
using System.Collections.Generic;
using Blog.Models;

namespace Blog.ViewModels
{
    public class PostPageData
    {
        public Post Post { get; set; }

        public List<Comment> Comments { get; set; }

        public PostPageData()
        {
        }
    }
}
