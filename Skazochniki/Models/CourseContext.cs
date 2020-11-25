using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Skazochniki.Models
{
    public class CourseContext : DbContext
    {
        public DbSet<Course> Course { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}