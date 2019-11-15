using System.Collections.Generic;

namespace Blog.View_Models
{
    public class BlogAddBlogViewModel
    {
        public IEnumerable<Models.User> Users { get; set; }
        
        public IEnumerable<Models.Blog> Blogs { get; set; }
    }
}

