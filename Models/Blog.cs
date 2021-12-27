using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string AuthorId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage ="The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }
        
        public IFormFile Image { get; set; }

    }
}
