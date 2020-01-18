using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcJqueryMobile.Models;

namespace MvcJqueryMobile.Models
{
    public class MobileContext:DbContext
    {
        public MobileContext() : base("MobileDbConnection") { }

        public DbSet<Hero> Heroes { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}