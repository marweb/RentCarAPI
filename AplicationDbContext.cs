using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rentcar
{
    public class AplicationDbContext: DbContext
    {
        //internal IEnumerable<object> car;

        public DbSet<Models.Car> Cars { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.User> Users { get; set; }

        public AplicationDbContext()
        {
            Database.EnsureCreated();
        }

        public AplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user=root;password=panama;database=carsapi;",
                new MySqlServerVersion(new Version(8, 0, 11)));
            }

        }
    }
}
