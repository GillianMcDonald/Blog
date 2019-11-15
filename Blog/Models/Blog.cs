using System;
using System.Collections. Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace Blog.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        
        public string Name { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string ActualBlog { get; set; }
        
        public string ImageUrl { get; set; }
        
        public string ImageThumbnailUrl { get; set; }
        
        public bool IsBlogOfTheWeek { get; set; }
        public int UserId { get; set; }
        
        public User User { get; set; }
        
        public string Writer { get; set; }
    }
}