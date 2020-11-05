using Microsoft.AspNetCore.Identity;

namespace SimpleNetBlog.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; } = "";
    }
}