using System;

namespace SimpleNetBlog.ViewModels
{
    public class CreateOrUpdateViewModel
    {
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}