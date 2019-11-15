using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.Models;
using Blog.View_Models;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {  
        private readonly IBlogRepository _blogRepository;
        private readonly IUserRepository _userRepository;
      

        public BlogController(IUserRepository userRepository, IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
            _userRepository = userRepository;
        }

        //GET /<controller>/
        public ViewResult List()
        {
            //setting the new view 
            BlogListViewModel blogListViewModel = new BlogListViewModel();
            blogListViewModel.Blogs = _blogRepository.AllBlogs;

            //setting a title 
            blogListViewModel.CurrentTitle = "Blog Feed";
            
            //returning the view 
            return View(blogListViewModel);
        }

        // setting the in action for the detail of a blog
//        public IActionResult Details(int id)
//        {
//
//            var blog = _blogRepository.GetBlogById(id);
//            if (blog == null)
//                return NotFound();
//            return View((blog));
//        }

        private readonly ILogger<BlogController> _logger;

//        public BlogController(ILogger<BlogController> logger)
//        {
//            _logger = logger;
//        }

        public IActionResult Details()
        {
            //setting the new view 
            BlogListViewModel blogListViewModel = new BlogListViewModel();
            blogListViewModel.Blogs = _blogRepository.AllBlogs;

            //setting a title 
            blogListViewModel.CurrentTitle = "Blog Feed";
            
            //returning the view 
            return View(blogListViewModel);
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult AddBlog()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }


       
    }
}