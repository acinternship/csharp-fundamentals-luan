using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostController: Controller
    {

        private static List<BlogPost> _posts = new List<BlogPost>
        {
            new BlogPost { Id = 1,Title = "Post1", CreatedAt = DateTime.Now,
            Content = "Teste" },

             new BlogPost { Id = 2,Title = "Post2", CreatedAt = DateTime.Now,
            Content = "Teste2" }
        };

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index()
        {
            return View(_posts);

        }
        public IActionResult Create(BlogPost post)
        {
            post.CreatedAt = DateTime.Now;
            _posts.Add(post);

            return RedirectToAction("Index"); 

        }
    }
}
