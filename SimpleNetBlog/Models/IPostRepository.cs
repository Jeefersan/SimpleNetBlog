using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleNetBlog.Models
{
    public interface IPostRepository
    {
        Task<Post> Add(Post post);
        Task<Post> Update(Post updatedPost);
        Task Remove(int postId);
        Task<Post> Get(int postId);
        Task<List<Post>> GetAll();

    }
}