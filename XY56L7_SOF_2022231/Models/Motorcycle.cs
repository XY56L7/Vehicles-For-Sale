using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XY56L7_SOF_2022231.Models
{
    public class Motorcycle
    {
        [Key]
        public string Uid { get; set; }
        [Required]
        public string Title { get; set; }
        public string OwnerId { get; set; }
        [NotMapped]
        public virtual SiteUser Owner { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Age { get; set; }
        public Motorcycle()
        {

            Uid = Guid.NewGuid().ToString();
        }
    }
}
