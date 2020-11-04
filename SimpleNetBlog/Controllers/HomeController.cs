using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleNetBlog.Models;
using SimpleNetBlog.ViewModels;

namespace SimpleNetBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostRepository _postRepository;

        public HomeController(ILogger<HomeController> logger, IPostRepository postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _postRepository.GetAll();
            var postsViewModel = new PostsViewModel

            {
                Posts = posts
                    .OrderBy(post => post.CreatedDate)
            };
            return View(postsViewModel);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public async Task<IActionResult> Post(int id)
        {
            var post = await _postRepository.Get(id);
            if (post != null)
            {
                return View(post);
            }

            return NotFound();
        }
    }
}