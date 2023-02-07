﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string? BlogUserId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} amd at most {1} characters.", MinimumLength = 2)]
        public string? Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} amd at most {1} characters.", MinimumLength = 2)]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created On ")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated On ")]
        public DateTime Updated { get; set; }

        [Display(Name = "Blog Image")]
        public byte[]? ImageData { get; set; }

        [Display(Name = "Image Type")]
        public string? ContentType { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }

        //Navigation Property
        [Display(Name="Author")]
        public virtual BlogUser? BlogUser { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();

    }
}