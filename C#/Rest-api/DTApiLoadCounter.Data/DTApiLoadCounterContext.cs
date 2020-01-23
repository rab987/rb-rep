using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using DTApiLoadCounter.Data.Entities;

namespace DTApiLoadCounter.Data
{
    public class DTApiLoadCounterContext : DbContext
    {
        public DTApiLoadCounterContext(string connectionString)
            : base(GetOptions(connectionString))
        {
        }
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
        public DbSet<DailyJobs> DailyJobs { get; set; }
        public DbSet<DailyJobDrivers> DailyJobDrivers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DailyJobs>()
                .HasKey(key => key.Id);
            modelBuilder.Entity<DailyJobDrivers>()
                .HasKey(key => key.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
