using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AidImpactTraining.Models
{
    public class BlogDataContext : DbContext 
    {
        public DbSet<Post> Posts { get; set; }

        public BlogDataContext(DbContextOptions<BlogDataContext> options)
            : base(options)
        {
            // Verify that the database has been created
            Database.EnsureCreated();
        }
    }
}
