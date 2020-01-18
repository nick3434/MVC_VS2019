using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcJqueryMobile.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
    }
}