using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleNetBlog.Models;

namespace SimpleNetBlog.Data
{
    public static class SeedData
    {
        
        public static void Initialize(ModelBuilder builder)
        {

 
            builder.Entity<Post>().HasData(new Post
            {
                Title = "My first post!",
                PostId = 1,
                Content = "This is my first ever post created!"
            });
            
            builder.Entity<Post>().HasData(new Post
            {
                Title = "My second post!",
                PostId = 2,
                Content = "This is my second post on SimpleNetBlog!"
            });

            builder.Entity<Post>().HasData(new Post
            {
                Title = "My third post!",
                PostId = 3,
                Content = "This is my third post on SimpleNetBlog!"
            });
            
        }
    }
}