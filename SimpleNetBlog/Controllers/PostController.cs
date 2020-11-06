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
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;
        private readonly IPostRepository _postRepository;

        public PostController(ILogger<PostController> logger, IPostRepository postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }
        
        [HttpGet]
        public async Task<IActionResult> EditPost(int id)
        {
            if (id == 0)
            {
                return View(new Post());
            }
            

            var post = await _postRepository.Get((int) id);
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> EditPost(Post updatedPost)
        {
            Post post;
            if (updatedPost.PostId == 0)
            {
                post = await _postRepository.Add(updatedPost);
            }
            else
            {
                post = await _postRepository.Update(updatedPost);
            }
            return RedirectToAction("Post", "Home", new {id = post.PostId});
        }


        public async Task<IActionResult> RemovePost(int id)
        {
            await _postRepository.Remove(id);

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}