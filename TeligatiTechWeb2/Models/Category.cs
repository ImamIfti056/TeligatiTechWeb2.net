﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeligatiTechWeb2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Component { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Image Link")]
        public string ImgUrl { get; set; }
        [DisplayName("Price")]
        public int Price { get; set; }
    }
}
