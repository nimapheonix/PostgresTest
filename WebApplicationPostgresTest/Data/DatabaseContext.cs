using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.Models;

namespace WebApplicationPostgresTest.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
           
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("host=127.0.0.1;port=5432;database=DNTest;user id=DNTestUser;password=123!@#");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Device>()
            //.HasKey(p => new { p.Id });
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Position>()
              .HasKey(p => new { p.DeviceId });
        }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Position> Positions { get; set; }

    }
}
