using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Price { get; set; }
        [MaxLength(50)]
        public string DiscountPrice { get; set; }

        public DateTime CreatedDiscount { get; set; }
        [MaxLength(250)]
        public string Img { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
