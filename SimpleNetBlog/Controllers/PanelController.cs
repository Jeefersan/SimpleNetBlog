using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleNetBlog.Models;
using SimpleNetBlog.ViewModels;

namespace SimpleNetBlog.Controllers
{
    [Authorize]
    public class PanelController : Controller
    {
        private readonly ILogger<PanelController> _logger;
        private readonly IPostRepository _postRepository;

        public PanelController(ILogger<PanelController> logger, IPostRepository postRepository)
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

        [HttpGet]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return View(new Post());
            }
            var post = await _postRepository.Get((int)id);
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> EditPost(Post updatedPost)
        {
            var post = await _postRepository.Update(updatedPost);
            return RedirectToAction("Post", new {id = post.PostId});
        }
        
        [HttpGet]
        public async Task<IActionResult> Post(int id)
        {
            var post = await _postRepository.Get(id);
            if (post != null)
            {
                ViewData["Title"] = post.Title;
                return View(post);
            }
            return NotFound();
        }

        public async Task<IActionResult> RemovePost(int id)
        {
            await _postRepository.Remove(id);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}