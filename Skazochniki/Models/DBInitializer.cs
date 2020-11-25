using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Skazochniki.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            context.Course.Add(new Course() { Name = "Test1", Price = 4000 });

            context.Course.Add(new Course() { Name = "Test2", Price = 3000 });

            context.Course.Add(new Course() { Name = "Test3", Price = 2000 });

            base.Seed(context); 
        }
    }
}