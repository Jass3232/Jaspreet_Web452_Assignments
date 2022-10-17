using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MvcPants.Models
{
    public class Pants
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public string Color { get; set; }
        public decimal Price { get; set; }

        [Range(1, 5)]
        public int Ratings { get; set; }
    }
}
