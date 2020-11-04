using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleNetBlog.Data;

namespace SimpleNetBlog.Models
{
    public class PostRepository : IPostRepository
    {
        private ApplicationDbContext _db;

        public PostRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<Post> Add(Post post)
        {
            await _db.AddAsync(post);
            await _db.SaveChangesAsync();
            return post;
        }

        public async Task<Post> Update(Post updatedPost)
        {
            var post = await Get(updatedPost.PostId);
            post.Title = updatedPost.Title;
            post.Content = updatedPost.Content;
            post.LastUpdatedDate = DateTime.Now;

            await _db.SaveChangesAsync();
            return updatedPost;
        }

        public async Task Remove(int postId)
        {
            var post = await Get(postId);
            _db.Remove(post);
            await _db.SaveChangesAsync();
        }

        public async Task<Post> Get(int postId)
        {
            return await _db.Posts.FirstOrDefaultAsync(post => post.PostId == postId);
        }

        public async Task<List<Post>> GetAll()
        {
            return await _db.Posts.ToListAsync();
        }
    }
}