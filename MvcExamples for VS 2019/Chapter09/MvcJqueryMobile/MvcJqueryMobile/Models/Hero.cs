using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcJqueryMobile.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string PageId { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Introduction { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public string VideoUrl { get; set; }
    }
}