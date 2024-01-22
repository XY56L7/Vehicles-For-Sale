﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XY56L7_SOF_2022231.Models
{
    public class Car
    {
        [Key]
        public string Uid { get; set; }
        public string Title { get; set; }
        public string OwnerId { get; set; }
        [NotMapped]
        public virtual SiteUser Owner { get; set; }
        public Car()
        {

               Uid = Guid.NewGuid().ToString();
        }
    }
}
