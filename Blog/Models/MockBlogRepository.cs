using System;
using System.Collections. Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace Blog.Models
{
    public class MockBlogRepository: IBlogRepository
    {
        private readonly IUserRepository _userRepository = new MockUserRepository();

        public IEnumerable<Blog> AllBlogs =>
            new List<Blog>
            {
                new Blog
                {
                    UserId = 1, Name = "How to Code", BlogId = 11, User = _userRepository.AllUsers.ToList()[0], 
                    ImageUrl = "",
                    IsBlogOfTheWeek = true, 
                    ImageThumbnailUrl = "/images/thumbnail.gif",
                    ShortDescription = "This is the short Description", ActualBlog = "This will be the Blog content",
                    Writer = "ME"
                },
                new Blog
                {
                    UserId = 2, Name = "How NOT to Code", BlogId = 12, User = _userRepository.AllUsers.ToList()[1],
                    ImageUrl = "", 
                    IsBlogOfTheWeek = false, 
                    ImageThumbnailUrl = "/images/thumbnail.gif",
                    ShortDescription = "This is the short Description", ActualBlog = "This will be the Blog content",
                    Writer = "THEM"
                },
                new Blog
                {
                    UserId = 3, Name = "Do you know how to Code?", BlogId = 13, User = _userRepository.AllUsers.ToList()[2],
                    ImageUrl = "", 
                    IsBlogOfTheWeek = false, 
                    ImageThumbnailUrl = "/images/thumbnail.gif",
                    ShortDescription = "This is the short Description", ActualBlog = "This will be the Blog content",
                    Writer = "YOU"
                },
            };
        
        public IEnumerable<Blog> BlogOfTheWeek { get; }

        public Blog GetBlogById(int blogId)
        {
            return AllBlogs.FirstOrDefault(b => b.BlogId == blogId);
        }
    }
}