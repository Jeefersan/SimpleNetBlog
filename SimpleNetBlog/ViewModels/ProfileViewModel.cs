using System.ComponentModel.DataAnnotations;

namespace SimpleNetBlog.ViewModels
{
    public class ProfileViewModel
    {
        [Required] public string DisplayName { get; set; }

        [Required] public string EmailAddress { get; set; }
        
    }
}