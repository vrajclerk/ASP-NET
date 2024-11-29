using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _6.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext() : base("name=SchoolDBConnectionString") // Specify the connection string name
        { }

        public DbSet<Student> Students { get; set; }
    }
}