using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheBlogProject.Enums;

namespace TheBlogProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Display(Name = "Blog name")]
        public string BlogId { get; set; }
        public string BlogUserId { get; set; }

        [Required]
        [StringLength(75, ErrorMessage ="The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
        public string Abstract { get; set; }
        
        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created date")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated date")]
        public DateTime? Updated { get; set; }


        public ReadyStatus ReadyStatus { get; set; }

        public string Slug { get; set; }

        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        //Nav props

        public virtual Blog Blog { get; set; }
        public virtual BlogUser BlogUser { get; set; }
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();    
        public virtual ICollection<Tag> Tags { get; set; }= new HashSet<Tag>(); 
    }
}
