using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace TeligatiTechWeb2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string? Address { get; set; }

        public string? Gender { get; set; }
    }
}
