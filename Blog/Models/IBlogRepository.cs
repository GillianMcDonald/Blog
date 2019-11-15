using System;
using System.Collections. Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace Blog.Models
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> AllBlogs { get; }
        
        IEnumerable<Blog> BlogOfTheWeek { get; }

        Blog GetBlogById(int blogId);
    }
}