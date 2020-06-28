using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AidImpactTraining.Models
{
    public class IdentityDataContext : IdentityDbContext<IdentityUser>
    {
        /// <summary>
        /// Set up the Identity services for the communication with the database
        /// </summary>
        /// <param name="options"></param>
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
            : base(options)
        {
            // Verify that the database has been created
            Database.EnsureCreated();
        }
    }
}
