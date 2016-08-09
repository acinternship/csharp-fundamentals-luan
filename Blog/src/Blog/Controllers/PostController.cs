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
        private BlogDbContext _dbContext;

        public PostController(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }       
        public IActionResult Index()
        {
            return View(_dbContext.Posts.ToList());

        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(BlogPost post)
        {
            post.CreatedAt = DateTime.Now;
            _dbContext.Add(post);
            _dbContext.SaveChanges();
            return RedirectToAction("Index"); 

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _dbContext.Posts.FirstOrDefault(p => p.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(BlogPost post)
        {
            var model = _dbContext.Posts.FirstOrDefault (p => p.Id == post.Id);
            model.Title = post.Title;
            model.Content = post.Content;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = _dbContext.Posts.FirstOrDefault(p => p.Id == id);

            _dbContext.Posts.Remove(model);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
