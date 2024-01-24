using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace XY56L7_SOF_2022231.Models
{
    public class SiteUser :IdentityUser
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }

    }
}
