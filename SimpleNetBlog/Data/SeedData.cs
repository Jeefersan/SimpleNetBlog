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
                Content = "<p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo. Quisque sit amet est et sapien ullamcorper pharetra. Vestibulum erat wisi, condimentum sed, commodo vitae, ornare sit amet, wisi. Aenean fermentum, elit eget tincidunt condimentum, eros ipsum rutrum orci, sagittis tempus lacus enim ac dui. Donec non enim in turpis pulvinar facilisis. Ut felis. Praesent dapibus, neque id cursus faucibus, tortor neque egestas augue, eu vulputate magna eros eu erat. Aliquam erat volutpat. Nam dui mi, tincidunt quis, accumsan porttitor, facilisis luctus, metus</p>"
            });
            
            builder.Entity<Post>().HasData(new Post
            {
                Title = "My second post!",
                PostId = 2,
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eu justo nunc. Nam cursus tempus elit, vitae volutpat nibh laoreet in. Vestibulum rhoncus ligula nunc. Pellentesque ante leo, sollicitudin vitae nisl eu, volutpat dignissim est. Aenean sollicitudin eros vestibulum, sagittis urna sed, tincidunt leo. Fusce ullamcorper lacinia massa id vestibulum. Quisque eu ex accumsan, facilisis diam et, vehicula erat. Donec dignissim in mi quis efficitur. Nullam ornare nulla non lorem hendrerit feugiat suscipit et velit. Donec lobortis eros dapibus, imperdiet ligula sit amet, mollis libero. Nulla suscipit eros eget odio placerat, nec venenatis leo finibus. Sed vitae tempor ipsum, at varius enim. Donec vel velit tempor, lobortis erat sed, hendrerit urna."
            });
            
            
        }
    }
}