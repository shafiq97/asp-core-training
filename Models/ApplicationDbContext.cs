using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vidly.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDb; Database=Movie; Trusted_Connection=True; MultipleActiveResultSets=True");

            }
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<MembershipType> MembershipType { get; set; }


    }
}
