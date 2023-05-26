using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TeligatiTechWeb2.Models
{
    public class Cart
    {
        public Category category { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
        public string Component { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Image Link")]
        public string ImgUrl { get; set; }
        [DisplayName("Price")]
        public int Price { get; set; }
    }
}
