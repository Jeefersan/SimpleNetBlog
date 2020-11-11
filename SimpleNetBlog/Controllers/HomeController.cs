
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
                    .OrderByDescending(post => post.CreatedDate)
            };
            return View(postsViewModel);
        }
        
        public async Task<IActionResult> Post(int id)
        {
            var post = await _postRepository.Get(id);
            if (post != null)
            {
                post.CreatedDate = post.CreatedDate;
                return View(post);
            }

            return NotFound();
        }
    }
}