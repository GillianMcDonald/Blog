using System.Collections.Generic;

namespace Blog.View_Models
{
    public class BlogListViewModel
    {
        public IEnumerable<Models.Blog> Blogs { get; set; }
        
        public string CurrentTitle { get; set; }
    }
}

