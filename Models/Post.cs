using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string BlogId { get; set; }
        public string AuthorId { get; set; }

        [Required]
        [StringLength(75, ErrorMessage ="The {0} must be at least {2} and no more than {1} characters long")]
        public string Title { get; set; }

    }
}
