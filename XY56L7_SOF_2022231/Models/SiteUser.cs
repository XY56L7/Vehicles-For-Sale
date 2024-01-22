using Microsoft.AspNetCore.Identity;

namespace XY56L7_SOF_2022231.Models
{
    public class SiteUser :IdentityUser
    {
        public string FirstName { get; set; }
        public int Wealth { get; set; }
        public string LastName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public SiteUser()
        {
            this.Wealth = 50000;
        }
    }
}
